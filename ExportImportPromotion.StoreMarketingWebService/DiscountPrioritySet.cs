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
	[GeneratedCode("System.Xml", "4.0.30319.1"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("DiscountPrioritySet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class DiscountPrioritySet : DataSet
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DiscountPriorityRowChangeEventHandler(object sender, DiscountPrioritySet.DiscountPriorityRowChangeEvent e);
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DiscountPriorityDataTable : DataTable, IEnumerable
		{
			private DataColumn columnCampaignItemId;
			private DataColumn columnPriority;
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DiscountPrioritySet.DiscountPriorityRowChangeEventHandler DiscountPriorityRowChanging;
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DiscountPrioritySet.DiscountPriorityRowChangeEventHandler DiscountPriorityRowChanged;
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DiscountPrioritySet.DiscountPriorityRowChangeEventHandler DiscountPriorityRowDeleting;
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DiscountPrioritySet.DiscountPriorityRowChangeEventHandler DiscountPriorityRowDeleted;
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public DataColumn CampaignItemIdColumn
			{
				get
				{
					return this.columnCampaignItemId;
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public DataColumn PriorityColumn
			{
				get
				{
					return this.columnPriority;
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
			public DiscountPrioritySet.DiscountPriorityRow this[int index]
			{
				get
				{
					return (DiscountPrioritySet.DiscountPriorityRow)base.Rows[index];
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public DiscountPriorityDataTable()
			{
				base.TableName = "DiscountPriority";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			internal DiscountPriorityDataTable(DataTable table)
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
			protected DiscountPriorityDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public void AddDiscountPriorityRow(DiscountPrioritySet.DiscountPriorityRow row)
			{
				base.Rows.Add(row);
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public DiscountPrioritySet.DiscountPriorityRow AddDiscountPriorityRow(int CampaignItemId, int Priority)
			{
				DiscountPrioritySet.DiscountPriorityRow discountPriorityRow = (DiscountPrioritySet.DiscountPriorityRow)base.NewRow();
				object[] itemArray = new object[]
				{
					CampaignItemId,
					Priority
				};
				discountPriorityRow.ItemArray = itemArray;
				base.Rows.Add(discountPriorityRow);
				return discountPriorityRow;
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DiscountPrioritySet.DiscountPriorityDataTable discountPriorityDataTable = (DiscountPrioritySet.DiscountPriorityDataTable)base.Clone();
				discountPriorityDataTable.InitVars();
				return discountPriorityDataTable;
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DiscountPrioritySet.DiscountPriorityDataTable();
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnCampaignItemId = base.Columns["CampaignItemId"];
				this.columnPriority = base.Columns["Priority"];
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnCampaignItemId = new DataColumn("CampaignItemId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnCampaignItemId);
				this.columnPriority = new DataColumn("Priority", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnPriority);
				this.columnCampaignItemId.AllowDBNull = false;
				this.columnPriority.AllowDBNull = false;
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public DiscountPrioritySet.DiscountPriorityRow NewDiscountPriorityRow()
			{
				return (DiscountPrioritySet.DiscountPriorityRow)base.NewRow();
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DiscountPrioritySet.DiscountPriorityRow(builder);
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DiscountPrioritySet.DiscountPriorityRow);
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.DiscountPriorityRowChanged != null)
				{
					this.DiscountPriorityRowChanged(this, new DiscountPrioritySet.DiscountPriorityRowChangeEvent((DiscountPrioritySet.DiscountPriorityRow)e.Row, e.Action));
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.DiscountPriorityRowChanging != null)
				{
					this.DiscountPriorityRowChanging(this, new DiscountPrioritySet.DiscountPriorityRowChangeEvent((DiscountPrioritySet.DiscountPriorityRow)e.Row, e.Action));
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.DiscountPriorityRowDeleted != null)
				{
					this.DiscountPriorityRowDeleted(this, new DiscountPrioritySet.DiscountPriorityRowChangeEvent((DiscountPrioritySet.DiscountPriorityRow)e.Row, e.Action));
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.DiscountPriorityRowDeleting != null)
				{
					this.DiscountPriorityRowDeleting(this, new DiscountPrioritySet.DiscountPriorityRowChangeEvent((DiscountPrioritySet.DiscountPriorityRow)e.Row, e.Action));
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public void RemoveDiscountPriorityRow(DiscountPrioritySet.DiscountPriorityRow row)
			{
				base.Rows.Remove(row);
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DiscountPrioritySet discountPrioritySet = new DiscountPrioritySet();
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
				xmlSchemaAttribute.FixedValue = discountPrioritySet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DiscountPriorityDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = discountPrioritySet.GetSchemaSerializable();
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
		public class DiscountPriorityRow : DataRow
		{
			private DiscountPrioritySet.DiscountPriorityDataTable tableDiscountPriority;
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public int CampaignItemId
			{
				get
				{
					return (int)base[this.tableDiscountPriority.CampaignItemIdColumn];
				}
				set
				{
					base[this.tableDiscountPriority.CampaignItemIdColumn] = value;
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public int Priority
			{
				get
				{
					return (int)base[this.tableDiscountPriority.PriorityColumn];
				}
				set
				{
					base[this.tableDiscountPriority.PriorityColumn] = value;
				}
			}
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			internal DiscountPriorityRow(DataRowBuilder rb) : base(rb)
			{
				this.tableDiscountPriority = (DiscountPrioritySet.DiscountPriorityDataTable)base.Table;
			}
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DiscountPriorityRowChangeEvent : EventArgs
		{
			private DiscountPrioritySet.DiscountPriorityRow eventRow;
			private DataRowAction eventAction;
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
			public DiscountPrioritySet.DiscountPriorityRow Row
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
			public DiscountPriorityRowChangeEvent(DiscountPrioritySet.DiscountPriorityRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}
		private DiscountPrioritySet.DiscountPriorityDataTable tableDiscountPriority;
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public DiscountPrioritySet.DiscountPriorityDataTable DiscountPriority
		{
			get
			{
				return this.tableDiscountPriority;
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
		public DiscountPrioritySet()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		protected DiscountPrioritySet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
					if (dataSet.Tables["DiscountPriority"] != null)
					{
						base.Tables.Add(new DiscountPrioritySet.DiscountPriorityDataTable(dataSet.Tables["DiscountPriority"]));
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
			DiscountPrioritySet discountPrioritySet = (DiscountPrioritySet)base.Clone();
			discountPrioritySet.InitVars();
			discountPrioritySet.SchemaSerializationMode = this.SchemaSerializationMode;
			return discountPrioritySet;
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
				if (dataSet.Tables["DiscountPriority"] != null)
				{
					base.Tables.Add(new DiscountPrioritySet.DiscountPriorityDataTable(dataSet.Tables["DiscountPriority"]));
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
			this.tableDiscountPriority = (DiscountPrioritySet.DiscountPriorityDataTable)base.Tables["DiscountPriority"];
			if (initTable)
			{
				if (this.tableDiscountPriority != null)
				{
					this.tableDiscountPriority.InitVars();
				}
			}
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		private void InitClass()
		{
			base.DataSetName = "DiscountPrioritySet";
			base.Prefix = "";
			base.Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/DiscountPrioritySet";
			base.Locale = new CultureInfo("en-US");
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableDiscountPriority = new DiscountPrioritySet.DiscountPriorityDataTable();
			base.Tables.Add(this.tableDiscountPriority);
		}
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
		private bool ShouldSerializeDiscountPriority()
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
			DiscountPrioritySet discountPrioritySet = new DiscountPrioritySet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = discountPrioritySet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = discountPrioritySet.GetSchemaSerializable();
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
