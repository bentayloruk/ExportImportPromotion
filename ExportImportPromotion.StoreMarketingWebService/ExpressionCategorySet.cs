using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
	[GeneratedCode("System.Xml", "4.0.30319.1"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("ExpressionCategorySet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class ExpressionCategorySet : DataSet
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void ExpressionCategoryRowChangeEventHandler(object sender, ExpressionCategorySet.ExpressionCategoryRowChangeEvent e);
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class ExpressionCategoryDataTable : DataTable, IEnumerable
		{
			private DataColumn columnCategory;
			private DataColumn columnProfile;
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event ExpressionCategorySet.ExpressionCategoryRowChangeEventHandler ExpressionCategoryRowChanging;
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event ExpressionCategorySet.ExpressionCategoryRowChangeEventHandler ExpressionCategoryRowChanged;
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event ExpressionCategorySet.ExpressionCategoryRowChangeEventHandler ExpressionCategoryRowDeleting;
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event ExpressionCategorySet.ExpressionCategoryRowChangeEventHandler ExpressionCategoryRowDeleted;
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public DataColumn CategoryColumn
			{
				get
				{
					return this.columnCategory;
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public DataColumn ProfileColumn
			{
				get
				{
					return this.columnProfile;
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public ExpressionCategorySet.ExpressionCategoryRow this[int index]
			{
				get
				{
					return (ExpressionCategorySet.ExpressionCategoryRow)base.Rows[index];
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public ExpressionCategoryDataTable()
			{
				base.TableName = "ExpressionCategory";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			internal ExpressionCategoryDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			protected ExpressionCategoryDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public void AddExpressionCategoryRow(ExpressionCategorySet.ExpressionCategoryRow row)
			{
				base.Rows.Add(row);
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public ExpressionCategorySet.ExpressionCategoryRow AddExpressionCategoryRow(string Category, string Profile)
			{
				ExpressionCategorySet.ExpressionCategoryRow expressionCategoryRow = (ExpressionCategorySet.ExpressionCategoryRow)base.NewRow();
				object[] itemArray = new object[]
				{
					Category,
					Profile
				};
				expressionCategoryRow.ItemArray = itemArray;
				base.Rows.Add(expressionCategoryRow);
				return expressionCategoryRow;
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public ExpressionCategorySet.ExpressionCategoryRow FindByCategoryProfile(string Category, string Profile)
			{
				return (ExpressionCategorySet.ExpressionCategoryRow)base.Rows.Find(new object[]
				{
					Category,
					Profile
				});
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public override DataTable Clone()
			{
				ExpressionCategorySet.ExpressionCategoryDataTable expressionCategoryDataTable = (ExpressionCategorySet.ExpressionCategoryDataTable)base.Clone();
				expressionCategoryDataTable.InitVars();
				return expressionCategoryDataTable;
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new ExpressionCategorySet.ExpressionCategoryDataTable();
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnCategory = base.Columns["Category"];
				this.columnProfile = base.Columns["Profile"];
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnCategory = new DataColumn("Category", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCategory);
				this.columnProfile = new DataColumn("Profile", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnProfile);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnCategory,
					this.columnProfile
				}, true));
				this.columnCategory.AllowDBNull = false;
				this.columnCategory.MaxLength = 30;
				this.columnProfile.AllowDBNull = false;
				this.columnProfile.MaxLength = 128;
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public ExpressionCategorySet.ExpressionCategoryRow NewExpressionCategoryRow()
			{
				return (ExpressionCategorySet.ExpressionCategoryRow)base.NewRow();
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new ExpressionCategorySet.ExpressionCategoryRow(builder);
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(ExpressionCategorySet.ExpressionCategoryRow);
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.ExpressionCategoryRowChanged != null)
				{
					this.ExpressionCategoryRowChanged(this, new ExpressionCategorySet.ExpressionCategoryRowChangeEvent((ExpressionCategorySet.ExpressionCategoryRow)e.Row, e.Action));
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.ExpressionCategoryRowChanging != null)
				{
					this.ExpressionCategoryRowChanging(this, new ExpressionCategorySet.ExpressionCategoryRowChangeEvent((ExpressionCategorySet.ExpressionCategoryRow)e.Row, e.Action));
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.ExpressionCategoryRowDeleted != null)
				{
					this.ExpressionCategoryRowDeleted(this, new ExpressionCategorySet.ExpressionCategoryRowChangeEvent((ExpressionCategorySet.ExpressionCategoryRow)e.Row, e.Action));
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.ExpressionCategoryRowDeleting != null)
				{
					this.ExpressionCategoryRowDeleting(this, new ExpressionCategorySet.ExpressionCategoryRowChangeEvent((ExpressionCategorySet.ExpressionCategoryRow)e.Row, e.Action));
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public void RemoveExpressionCategoryRow(ExpressionCategorySet.ExpressionCategoryRow row)
			{
				base.Rows.Remove(row);
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				ExpressionCategorySet expressionCategorySet = new ExpressionCategorySet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = 79228162514264337593543950335m;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = expressionCategorySet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "ExpressionCategoryDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = expressionCategorySet.GetSchemaSerializable();
				XmlSchemaComplexType result;
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							XmlSchema xmlSchema = (XmlSchema)enumerator.Current;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									result = xmlSchemaComplexType;
									return result;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				result = xmlSchemaComplexType;
				return result;
			}
		}
		public class ExpressionCategoryRow : DataRow
		{
			private ExpressionCategorySet.ExpressionCategoryDataTable tableExpressionCategory;
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public string Category
			{
				get
				{
					return (string)base[this.tableExpressionCategory.CategoryColumn];
				}
				set
				{
					base[this.tableExpressionCategory.CategoryColumn] = value;
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public string Profile
			{
				get
				{
					return (string)base[this.tableExpressionCategory.ProfileColumn];
				}
				set
				{
					base[this.tableExpressionCategory.ProfileColumn] = value;
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			internal ExpressionCategoryRow(DataRowBuilder rb) : base(rb)
			{
				this.tableExpressionCategory = (ExpressionCategorySet.ExpressionCategoryDataTable)base.Table;
			}
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ExpressionCategoryRowChangeEvent : EventArgs
		{
			private ExpressionCategorySet.ExpressionCategoryRow eventRow;
			private DataRowAction eventAction;
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public ExpressionCategorySet.ExpressionCategoryRow Row
			{
				get
				{
					return this.eventRow;
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public ExpressionCategoryRowChangeEvent(ExpressionCategorySet.ExpressionCategoryRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}
		private ExpressionCategorySet.ExpressionCategoryDataTable tableExpressionCategory;
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public ExpressionCategorySet.ExpressionCategoryDataTable ExpressionCategory
		{
			get
			{
				return this.tableExpressionCategory;
			}
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), DebuggerNonUserCode]
		public override SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		public ExpressionCategorySet()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		protected ExpressionCategorySet(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			if (base.IsBinarySerialized(info, context))
			{
				this.InitVars(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
			}
			else
			{
				string s = (string)info.GetValue("XmlSchema", typeof(string));
				if (base.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
				{
					DataSet dataSet = new DataSet();
					dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
					if (dataSet.Tables["ExpressionCategory"] != null)
					{
						base.Tables.Add(new ExpressionCategorySet.ExpressionCategoryDataTable(dataSet.Tables["ExpressionCategory"]));
					}
					base.DataSetName = dataSet.DataSetName;
					base.Prefix = dataSet.Prefix;
					base.Namespace = dataSet.Namespace;
					base.Locale = dataSet.Locale;
					base.CaseSensitive = dataSet.CaseSensitive;
					base.EnforceConstraints = dataSet.EnforceConstraints;
					base.Merge(dataSet, false, MissingSchemaAction.Add);
					this.InitVars();
				}
				else
				{
					base.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				}
				base.GetSerializationData(info, context);
				CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.SchemaChanged);
				base.Tables.CollectionChanged += value2;
				this.Relations.CollectionChanged += value2;
			}
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		public override DataSet Clone()
		{
			ExpressionCategorySet expressionCategorySet = (ExpressionCategorySet)base.Clone();
			expressionCategorySet.InitVars();
			expressionCategorySet.SchemaSerializationMode = this.SchemaSerializationMode;
			return expressionCategorySet;
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["ExpressionCategory"] != null)
				{
					base.Tables.Add(new ExpressionCategorySet.ExpressionCategoryDataTable(dataSet.Tables["ExpressionCategory"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				base.ReadXml(reader);
				this.InitVars();
			}
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		internal void InitVars()
		{
			this.InitVars(true);
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		internal void InitVars(bool initTable)
		{
			this.tableExpressionCategory = (ExpressionCategorySet.ExpressionCategoryDataTable)base.Tables["ExpressionCategory"];
			if (initTable)
			{
				if (this.tableExpressionCategory != null)
				{
					this.tableExpressionCategory.InitVars();
				}
			}
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		private void InitClass()
		{
			base.DataSetName = "ExpressionCategorySet";
			base.Prefix = "";
#if MS
			base.Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/ExpressionCategorySet";
#else
			base.Namespace = "http://schemas.commerceserver.net/2013/01/CommerceServer/2006/06/MarketingWebService/ExpressionCategorySet";
#endif

			base.Locale = new CultureInfo("en-US");
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableExpressionCategory = new ExpressionCategorySet.ExpressionCategoryDataTable();
			base.Tables.Add(this.tableExpressionCategory);
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		private bool ShouldSerializeExpressionCategory()
		{
			return false;
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			ExpressionCategorySet expressionCategorySet = new ExpressionCategorySet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = expressionCategorySet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = expressionCategorySet.GetSchemaSerializable();
			XmlSchemaComplexType result;
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						XmlSchema xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								result = xmlSchemaComplexType;
								return result;
							}
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						memoryStream.Close();
					}
					if (memoryStream2 != null)
					{
						memoryStream2.Close();
					}
				}
			}
			xs.Add(schemaSerializable);
			result = xmlSchemaComplexType;
			return result;
		}
	}
}
