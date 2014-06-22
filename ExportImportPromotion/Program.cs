using System.Diagnostics;
using ExportImportPromotion.StoreMarketingWebService;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
namespace ExportImportPromotion
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			string message = "Usage:\r\n    ExportImportPromotion.exe /ex - to export discount related data to xml file. Options required:\r\n        /con - the marketing webservice url where you want to export discounts.\r\n\r\n    ExportImportPromotion.exe /im - to import discount. Options required:\r\n        /con - the marketing webservice url where you want to import discounts.\r\n        /d - the path to discounts xml to import.\r\n        /p - the path to promo codes xml associated to the discounts.\r\n        /ge - the path to global expression xml associated to the discounts.";
			string message2 = "The command parameter is invalid.";
			if (args == null || args.Length < 1)
			{
				Program.WriteLineToConsole(message);
			}
			else
			{
				try
				{
					string text = args[0].ToLower(CultureInfo.InvariantCulture);
					if (text != null)
					{
						if (text == "/?")
						{
							Program.WriteLineToConsole(message);
							return;
						}
						if (text == "/ex")
						{
							if (args.Length >= 2)
							{
								string a = args[1].ToLower(CultureInfo.InvariantCulture);
								if (!(a != "/con"))
								{
									if (2 < args.Length)
									{
										string webServiceUrl = args[2].ToLower(CultureInfo.InvariantCulture);
										Program.ExportDiscount(webServiceUrl);
										Program.WriteLineToConsole("Export discounts successful!...");
										return;
									}
								}
							}
						}
						else
						{
							if (text == "/im")
							{
								string text2 = string.Empty;
								string text3 = string.Empty;
								string text4 = string.Empty;
								string globalExpPath = string.Empty;
								int i = 1;
								while (i < args.Length)
								{
									string text5 = args[i].ToLower(CultureInfo.InvariantCulture);
									if (text5 != null)
									{
										if (!(text5 == "/con"))
										{
											if (!(text5 == "/d"))
											{
												if (!(text5 == "/p"))
												{
													if (text5 == "/ge")
													{
														if (i + 1 < args.Length)
														{
															globalExpPath = args[i + 1].ToLower(CultureInfo.InvariantCulture);
														}
													}
												}
												else
												{
													if (i + 1 < args.Length)
													{
														text4 = args[i + 1].ToLower(CultureInfo.InvariantCulture);
													}
												}
											}
											else
											{
												if (i + 1 < args.Length)
												{
													text3 = args[i + 1].ToLower(CultureInfo.InvariantCulture);
												}
											}
										}
										else
										{
											if (i + 1 < args.Length)
											{
												text2 = args[i + 1].ToLower(CultureInfo.InvariantCulture);
											}
										}
									}
									IL_241:
									i++;
									continue;
									goto IL_241;
								}
								if (!string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(text3) && !string.IsNullOrEmpty(text4))
								{
									Program.Import(text2, text3, globalExpPath, text4);
									Program.WriteLineToConsole("Import discounts successful!...");
									return;
								}
							}
						}
					}
					Program.WriteLineToConsole(message2);
					Program.WriteLineToConsole(message);
				}
				catch (Exception ex)
				{
					Program.WriteLineToConsole(ex.Message);
					Program.WriteLineToConsole(ex.InnerException.Message);
					Program.WriteLineToConsole(ex.StackTrace);
				}
			}
		}
		private static void Import(string webServiceUrl, string discountPath, string globalExpPath, string promoCodePath)
		{
			List<DiscountData> discounts = Program.DiscountsFromXML(discountPath);
			List<ExpressionData> globalExpression = Program.GlobalExpressionFromXML(globalExpPath);
			List<PromoCodeDefinitionData> promoCodes = Program.PromoCodesFromXML(promoCodePath);
			Program.ImportDiscounts(webServiceUrl, discounts, globalExpression, promoCodes);
		}
		internal static void WriteLineToConsole(string message)
		{
			Console.Out.WriteLine(message);
		}
		private static void ExportDiscount(string webServiceUrl)
		{
			using (MarketingService marketingService = new MarketingService(webServiceUrl))
			{
				marketingService.PreAuthenticate = false;
				marketingService.Credentials = CredentialCache.DefaultCredentials;
				DataSet dataSet = marketingService.ExecuteSearch("Discount", null, null, false);
				List<DiscountData> list = new List<DiscountData>();
				List<ExpressionData> list2 = new List<ExpressionData>();
				Hashtable expressDetailKeys = new Hashtable();
				List<PromoCodeDefinitionData> list3 = new List<PromoCodeDefinitionData>();
				Hashtable hashtable = new Hashtable();
				foreach (DataRow dataRow in dataSet.Tables[0].Rows)
				{
					DiscountData discountData = marketingService.GetCampaignItem(int.Parse(dataRow["ID"].ToString())) as DiscountData;
					object[] globalExpressions = new object[]
					{
						discountData.AwardExpression
					};
					Program.GetGlobalExpressions(globalExpressions, list2, expressDetailKeys, marketingService);
					object[] globalExpressions2 = new object[]
					{
						discountData.Condition.ConditionExpression
					};
					Program.GetGlobalExpressions(globalExpressions2, list2, expressDetailKeys, marketingService);
					Program.GetGlobalExpressions(discountData.Targets, list2, expressDetailKeys, marketingService);
					Program.GetGlobalExpressions(discountData.EligibilityRequirements, list2, expressDetailKeys, marketingService);
					if (discountData.PromoCodeDefinitionId != 0)
					{
						if (!hashtable.Contains(discountData.PromoCodeDefinitionId))
						{
							hashtable.Add(discountData.PromoCodeDefinitionId, new object());
							PromoCodeDefinitionData promoCodeDefinition = marketingService.GetPromoCodeDefinition(discountData.PromoCodeDefinitionId);
							list3.Add(promoCodeDefinition);
						}
					}
					list.Add(discountData);
				}
				DateTime now = DateTime.Now;
				string str = string.Format(CultureInfo.InvariantCulture, "{0}_{1}_{2}_{3}_{4}_{5}_{6}", new object[]
				{
					now.Year,
					now.Month,
					now.Day,
					now.Hour,
					now.Minute,
					now.Second,
					now.Millisecond
				});
				str = "";
				using (TextWriter textWriter = Program.CreateTextWriter(null, "Discount_" + str + ".xml"))
				{
					Type[] extraTypes = new Type[]
					{
						typeof(LanguageStringData),
						typeof(ExpressionTargetData),
						typeof(DisplayPropertyValueData)
					};
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<DiscountData>), extraTypes);
					xmlSerializer.Serialize(textWriter, list);
				}
				using (TextWriter textWriter = Program.CreateTextWriter(null, "GlobalExpressions_" + str + ".xml"))
				{
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<ExpressionData>));
					xmlSerializer.Serialize(textWriter, list2);
				}
				using (TextWriter textWriter = Program.CreateTextWriter(null, "PromoCodes_" + str + ".xml"))
				{
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<PromoCodeDefinitionData>));
					xmlSerializer.Serialize(textWriter, list3);
				}
			}
		}
		private static void GetGlobalExpressions(object[] globalExpressions, List<ExpressionData> expressionDetails, Hashtable expressDetailKeys, MarketingService svc)
		{
			if (globalExpressions != null)
			{
				for (int i = 0; i < globalExpressions.Length; i++)
				{
					object obj = globalExpressions[i];
					ExpressionRefData expressionRefData = null;
					if (obj is GlobalExpressionData)
					{
						expressionRefData = (GlobalExpressionData)obj;
					}
					else
					{
						if (obj is ExpressionTargetData)
						{
							ExpressionTargetData expressionTargetData = (ExpressionTargetData)obj;
							expressionRefData = expressionTargetData.Expression;
						}
					}
					if (expressionRefData != null)
					{
						if (expressionRefData is GlobalExpressionData)
						{
							GlobalExpressionData globalExpressionData = (GlobalExpressionData)expressionRefData;
							if (!expressDetailKeys.Contains(globalExpressionData.ExpressionId))
							{
								ExpressionData expression = svc.GetExpression(globalExpressionData.ExpressionId);
								if (expression != null)
								{
									expressDetailKeys.Add(globalExpressionData.ExpressionId, new object());
									expressionDetails.Add(expression);
								}
							}
						}
					}
				}
			}
		}
		private static List<DiscountData> DiscountsFromXML(string path)
		{
			Type[] extraTypes = new Type[]
			{
				typeof(LanguageStringData),
				typeof(ExpressionTargetData),
				typeof(DisplayPropertyValueData)
			};
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<DiscountData>), extraTypes);
			List<DiscountData> result = null;
			using (TextReader textReader = new StreamReader(path))
			{
				result = (List<DiscountData>)xmlSerializer.Deserialize(textReader);
			}
			return result;
		}
		private static List<ExpressionData> GlobalExpressionFromXML(string path)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<ExpressionData>));
			List<ExpressionData> result = null;
			using (TextReader textReader = new StreamReader(path))
			{
				result = (List<ExpressionData>)xmlSerializer.Deserialize(textReader);
			}
			return result;
		}
		private static List<PromoCodeDefinitionData> PromoCodesFromXML(string path)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<PromoCodeDefinitionData>));
			List<PromoCodeDefinitionData> result = null;
			using (TextReader textReader = new StreamReader(path))
			{
				result = (List<PromoCodeDefinitionData>)xmlSerializer.Deserialize(textReader);
			}
			return result;
		}
		private static string UTF8ByteArrayToString(byte[] characters)
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			return uTF8Encoding.GetString(characters);
		}
		private static TextWriter CreateTextWriter(IsolatedStorageFile isolatedStorageFolder, string path)
		{
			TextWriter result;
			if (isolatedStorageFolder == null)
			{
				result = new StreamWriter(path);
			}
			else
			{
				result = new StreamWriter(new IsolatedStorageFileStream(path, FileMode.OpenOrCreate, isolatedStorageFolder));
			}
			return result;
		}
		private static void GetTargetingProfile(XmlElement expBody, List<string> targetingProfiles)
		{
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(expBody.OwnerDocument.NameTable);
			xmlNamespaceManager.AddNamespace("ex", expBody.NamespaceURI);
			List<XmlNodeList> list = new List<XmlNodeList>();
			XmlNodeList item = expBody.SelectNodes("ex:CLAUSE/ex:PROPERTY", xmlNamespaceManager);
			list.Add(item);
			XmlNodeList item2 = expBody.SelectNodes("ex:PROPERTY", xmlNamespaceManager);
			list.Add(item2);
			foreach (XmlNodeList current in list)
			{
				foreach (XmlNode xmlNode in current)
				{
					XmlAttribute xmlAttribute = xmlNode.Attributes["ID"];
					string[] array = xmlAttribute.Value.Split(new char[]
					{
						'.'
					});
					string item3 = array[0];
					if (!targetingProfiles.Contains(item3))
					{
						targetingProfiles.Add(item3);
					}
				}
			}
		}
		private static void ImportDiscounts(string webServiceUrl, List<DiscountData> discounts, List<ExpressionData> globalExpression, List<PromoCodeDefinitionData> promoCodes)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
			List<string> list = new List<string>();
			using (MarketingService marketingService = new MarketingService(webServiceUrl))
			{
				marketingService.PreAuthenticate = false;
				marketingService.Credentials = CredentialCache.DefaultCredentials;
				if (globalExpression.Count > 0)
				{
					foreach (ExpressionData current in globalExpression)
					{
						Program.GetTargetingProfile(current.Body, list);
					}
					if (list.Count > 0)
					{
						ExpressionCategorySet allExpressionCategories = marketingService.GetAllExpressionCategories();
						foreach (ExpressionCategorySet.ExpressionCategoryRow expressionCategoryRow in allExpressionCategories.ExpressionCategory)
						{
							if (expressionCategoryRow.Category == "TargetCondition")
							{
								if (list.Contains(expressionCategoryRow.Profile))
								{
									list.Remove(expressionCategoryRow.Profile);
								}
								else
								{
									expressionCategoryRow.Delete();
								}
							}
						}
						foreach (string current2 in list)
						{
							allExpressionCategories.ExpressionCategory.AddExpressionCategoryRow("TargetCondition", current2);
						}
						marketingService.SaveExpressionCategories(allExpressionCategories);
					}
				}
				if (globalExpression.Count > 0)
				{
					foreach (ExpressionData current in globalExpression)
					{
						ExpressionData expressionData = marketingService.NewExpression();
						Program.CopyExpressData(expressionData, current);
						marketingService.SaveExpression(ref expressionData, true);
						dictionary.Add(current.Id, expressionData.Id);
						Program.GetTargetingProfile(expressionData.Body, list);
					}
					Program.UpdateGlobalExpMappings(discounts, dictionary);
				}
				if (promoCodes.Count > 0)
				{
					foreach (PromoCodeDefinitionData current3 in promoCodes)
					{
						PromoCodeDefinitionData promoCodeDefinitionData = marketingService.NewPromoCodeDefinition();
						Program.CopyPromCodeDefinition(promoCodeDefinitionData, current3);
						marketingService.SavePromoCodeDefinition(ref promoCodeDefinitionData, true);
						dictionary2.Add(current3.Id, promoCodeDefinitionData.Id);
					}
					Program.UpdatePromCodeMappings(discounts, dictionary2);
				}
				foreach (DiscountData current4 in discounts)
				{
					DiscountData discountData = marketingService.NewCampaignItem(CampaignItemType.Discount, current4.CampaignId) as DiscountData;
					Program.CopyDiscount(discountData, current4);
					CampaignItemData campaignItemData = discountData;
					marketingService.SaveCampaignItem(ref campaignItemData, true);
				}
			}
		}
		private static void UpdatePromCodeMappings(List<DiscountData> discounts, Dictionary<int, int> mappings)
		{
			foreach (DiscountData current in discounts)
			{
				if (mappings.ContainsKey(current.PromoCodeDefinitionId))
				{
					int promoCodeDefinitionId;
					mappings.TryGetValue(current.PromoCodeDefinitionId, out promoCodeDefinitionId);
					current.PromoCodeDefinitionId = promoCodeDefinitionId;
				}
			}
		}
		private static void UpdateGlobalExpMappings(List<DiscountData> discounts, Dictionary<int, int> mappings)
		{
			foreach (DiscountData current in discounts)
			{
				if (current.AwardExpression != null && current.AwardExpression is GlobalExpressionData)
				{
					GlobalExpressionData globalExpressionData = (GlobalExpressionData)current.AwardExpression;
					if (mappings.ContainsKey(globalExpressionData.ExpressionId))
					{
						int expressionId;
						mappings.TryGetValue(globalExpressionData.ExpressionId, out expressionId);
						globalExpressionData.ExpressionId = expressionId;
					}
				}
				if (current.Condition != null && current.Condition.ConditionExpression != null && current.Condition.ConditionExpression is GlobalExpressionData)
				{
					GlobalExpressionData globalExpressionData2 = (GlobalExpressionData)current.Condition.ConditionExpression;
					if (mappings.ContainsKey(globalExpressionData2.ExpressionId))
					{
						int expressionId;
						mappings.TryGetValue(globalExpressionData2.ExpressionId, out expressionId);
						globalExpressionData2.ExpressionId = expressionId;
					}
				}
				if (current.Targets != null)
				{
					object[] array = current.Targets;
					for (int i = 0; i < array.Length; i++)
					{
						object obj = array[i];
						ExpressionTargetData expressionTargetData = (ExpressionTargetData)obj;
						if (expressionTargetData.Expression is GlobalExpressionData)
						{
							if (mappings.ContainsKey(((GlobalExpressionData)expressionTargetData.Expression).ExpressionId))
							{
								int expressionId;
								mappings.TryGetValue(((GlobalExpressionData)expressionTargetData.Expression).ExpressionId, out expressionId);
								((GlobalExpressionData)expressionTargetData.Expression).ExpressionId = expressionId;
							}
						}
					}
				}
				if (current.EligibilityRequirements != null)
				{
					object[] array = current.EligibilityRequirements;
					for (int i = 0; i < array.Length; i++)
					{
						object obj = array[i];
						if (obj is GlobalExpressionData)
						{
							GlobalExpressionData globalExpressionData3 = (GlobalExpressionData)obj;
							if (mappings.ContainsKey(globalExpressionData3.ExpressionId))
							{
								int expressionId;
								mappings.TryGetValue(globalExpressionData3.ExpressionId, out expressionId);
								globalExpressionData3.ExpressionId = expressionId;
							}
						}
					}
				}
			}
		}
		private static void CopyExpressData(ExpressionData newExp, ExpressionData oldExp)
		{
			newExp.Body = oldExp.Body;
			newExp.Category = oldExp.Category;
			newExp.CreatedDate = oldExp.CreatedDate;
			newExp.Description = oldExp.Description;
			newExp.Local = oldExp.Local;
			newExp.Name = oldExp.Name;
			newExp.ProductPickerCatalog = oldExp.ProductPickerCatalog;
			newExp.ProductPickerCategory = oldExp.ProductPickerProduct;
		}
		private static void CopyPromCodeDefinition(PromoCodeDefinitionData nPromo, PromoCodeDefinitionData oldPromo)
		{
			nPromo.CodeGenerationError = oldPromo.CodeGenerationError;
			nPromo.CodeGenerationStatus = oldPromo.CodeGenerationStatus;
			nPromo.CreatedDate = oldPromo.CreatedDate;
			nPromo.Name = oldPromo.Name;
			nPromo.NumberOfCodes = oldPromo.NumberOfCodes;
			nPromo.PublicPromoCode = oldPromo.PublicPromoCode;
			nPromo.UsageLimit = oldPromo.UsageLimit;
			nPromo.UsageOption = oldPromo.UsageOption;
		}
		private static void CopyDiscount(DiscountData newDiscount, DiscountData oldDiscount)
		{
			newDiscount.AutoAddAward = oldDiscount.AutoAddAward;
			newDiscount.AwardExpression = oldDiscount.AwardExpression;
			newDiscount.CampaignId = oldDiscount.CampaignId;
			newDiscount.ClickRequired = oldDiscount.ClickRequired;
			newDiscount.Condition = oldDiscount.Condition;
			newDiscount.CustomOrderLevelOfferType = oldDiscount.CustomOrderLevelOfferType;
			newDiscount.Description = oldDiscount.Description;
			newDiscount.DiscountType = oldDiscount.DiscountType;
			newDiscount.EligibilityRequirements = oldDiscount.EligibilityRequirements;
			newDiscount.CreatedDate = DateTime.Now;
			newDiscount.EndDate = oldDiscount.EndDate;
			newDiscount.ExposureLimit = oldDiscount.ExposureLimit;
			newDiscount.MaxAwards = oldDiscount.MaxAwards;
			newDiscount.MultilingualBasketDisplay = oldDiscount.MultilingualBasketDisplay;
			newDiscount.Name = oldDiscount.Name;
			newDiscount.OfferAmount = oldDiscount.OfferAmount;
			newDiscount.OfferDisjoint = oldDiscount.OfferDisjoint;
			newDiscount.OfferType = oldDiscount.OfferType;
			newDiscount.PageGroups = oldDiscount.PageGroups;
			newDiscount.PerOrderLimit = oldDiscount.PerOrderLimit;
			newDiscount.Priority = 0;
			newDiscount.PropertyValues = oldDiscount.PropertyValues;
			newDiscount.ReuseAwardsAsAwards = oldDiscount.ReuseAwardsAsAwards;
			newDiscount.ReuseAwardsAsConditions = oldDiscount.ReuseAwardsAsConditions;
			newDiscount.ReuseConditionsAsAwards = oldDiscount.ReuseConditionsAsAwards;
			newDiscount.ReuseConditionsAsConditions = oldDiscount.ReuseConditionsAsConditions;
			newDiscount.SizeName = oldDiscount.SizeName;
			newDiscount.StartDate = DateTime.Now;
			newDiscount.Targets = oldDiscount.Targets;
			newDiscount.TemplateName = oldDiscount.TemplateName;
			newDiscount.UseEligibilityRequirementForTargeting = oldDiscount.UseEligibilityRequirementForTargeting;
			newDiscount.WizardType = oldDiscount.WizardType;
		}
	}
}
