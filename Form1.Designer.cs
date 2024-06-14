namespace interface5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.musical_groupDataSet = new interface5.Musical_groupDataSet();
            this.musical_groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musical_groupTableAdapter = new interface5.Musical_groupDataSetTableAdapters.Musical_groupTableAdapter();
            this.tableAdapterManager = new interface5.Musical_groupDataSetTableAdapters.TableAdapterManager();
            this.группа_альбомBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группа_альбомTableAdapter = new interface5.Musical_groupDataSetTableAdapters.группа_альбомTableAdapter();
            this.tableAdapterManager1 = new interface5.Musical_groupDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.musical_groupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musical_groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группа_альбомBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // musical_groupDataSet
            // 
            this.musical_groupDataSet.DataSetName = "Musical_groupDataSet";
            this.musical_groupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musical_groupBindingSource
            // 
            this.musical_groupBindingSource.DataMember = "Musical_group";
            this.musical_groupBindingSource.DataSource = this.musical_groupDataSet;
            // 
            // musical_groupTableAdapter
            // 
            this.musical_groupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Musical_groupTableAdapter = this.musical_groupTableAdapter;
            this.tableAdapterManager.UpdateOrder = interface5.Musical_groupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.группа_альбомTableAdapter = this.группа_альбомTableAdapter;
            this.tableAdapterManager.группа_музыкантыTableAdapter = null;
            this.tableAdapterManager.группа_премияTableAdapter = null;
            this.tableAdapterManager.группа_стильTableAdapter = null;
            this.tableAdapterManager.музыкантыTableAdapter = null;
            this.tableAdapterManager.премииTableAdapter = null;
            this.tableAdapterManager.ролиTableAdapter = null;
            this.tableAdapterManager.стилиTableAdapter = null;
            this.tableAdapterManager.странаTableAdapter = null;
            // 
            // группа_альбомBindingSource
            // 
            this.группа_альбомBindingSource.DataMember = "группа_альбом";
            this.группа_альбомBindingSource.DataSource = this.musical_groupDataSet;
            // 
            // группа_альбомTableAdapter
            // 
            this.группа_альбомTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.Musical_groupTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = interface5.Musical_groupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.группа_альбомTableAdapter = null;
            this.tableAdapterManager1.группа_музыкантыTableAdapter = null;
            this.tableAdapterManager1.группа_премияTableAdapter = null;
            this.tableAdapterManager1.группа_стильTableAdapter = null;
            this.tableAdapterManager1.музыкантыTableAdapter = null;
            this.tableAdapterManager1.премииTableAdapter = null;
            this.tableAdapterManager1.ролиTableAdapter = null;
            this.tableAdapterManager1.стилиTableAdapter = null;
            this.tableAdapterManager1.странаTableAdapter = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musical_groupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musical_groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группа_альбомBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Musical_groupDataSet musical_groupDataSet;
        private System.Windows.Forms.BindingSource musical_groupBindingSource;
        private Musical_groupDataSetTableAdapters.Musical_groupTableAdapter musical_groupTableAdapter;
        private Musical_groupDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Musical_groupDataSetTableAdapters.группа_альбомTableAdapter группа_альбомTableAdapter;
        private System.Windows.Forms.BindingSource группа_альбомBindingSource;
        private Musical_groupDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}