namespace ОООТехносервис.View
{
    partial class FiltrSearch
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
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.RequestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDeviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDefectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestStatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditRequest = new System.Windows.Forms.Button();
            this.buttonAddRequest = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequestId,
            this.RequestDate,
            this.RequestDeviceId,
            this.RequestDefectId,
            this.RequestClientId,
            this.RequestDescription,
            this.RequestStatusID});
            this.dataGridViewRequests.Location = new System.Drawing.Point(0, 101);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.Size = new System.Drawing.Size(745, 582);
            this.dataGridViewRequests.TabIndex = 0;
            // 
            // RequestId
            // 
            this.RequestId.HeaderText = "Номер заявки";
            this.RequestId.Name = "RequestId";
            // 
            // RequestDate
            // 
            this.RequestDate.HeaderText = "Дата подачи";
            this.RequestDate.Name = "RequestDate";
            // 
            // RequestDeviceId
            // 
            this.RequestDeviceId.HeaderText = "Оборудование";
            this.RequestDeviceId.Name = "RequestDeviceId";
            // 
            // RequestDefectId
            // 
            this.RequestDefectId.HeaderText = "ФИО клиента";
            this.RequestDefectId.Name = "RequestDefectId";
            // 
            // RequestClientId
            // 
            this.RequestClientId.HeaderText = "Статус";
            this.RequestClientId.Name = "RequestClientId";
            // 
            // RequestDescription
            // 
            this.RequestDescription.HeaderText = "ФИО мастера";
            this.RequestDescription.Name = "RequestDescription";
            // 
            // RequestStatusID
            // 
            this.RequestStatusID.HeaderText = "Этап";
            this.RequestStatusID.Name = "RequestStatusID";
            // 
            // buttonEditRequest
            // 
            this.buttonEditRequest.Location = new System.Drawing.Point(95, 62);
            this.buttonEditRequest.Name = "buttonEditRequest";
            this.buttonEditRequest.Size = new System.Drawing.Size(108, 23);
            this.buttonEditRequest.TabIndex = 1;
            this.buttonEditRequest.Text = "Редактировать";
            this.buttonEditRequest.UseVisualStyleBackColor = true;
            this.buttonEditRequest.Click += new System.EventHandler(this.buttonEditRequest_Click);
            // 
            // buttonAddRequest
            // 
            this.buttonAddRequest.Location = new System.Drawing.Point(12, 62);
            this.buttonAddRequest.Name = "buttonAddRequest";
            this.buttonAddRequest.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRequest.TabIndex = 2;
            this.buttonAddRequest.Text = "Добавить";
            this.buttonAddRequest.UseVisualStyleBackColor = true;
            this.buttonAddRequest.Click += new System.EventHandler(this.buttonAddRequest_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(674, 8);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(441, 62);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(308, 24);
            this.comboBoxStatus.TabIndex = 5;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(302, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фильтр по статусу";
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(209, 62);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(87, 23);
            this.buttonReport.TabIndex = 7;
            this.buttonReport.Text = "Отчеты";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Список заявок";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNumber.Location = new System.Drawing.Point(441, 35);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(308, 23);
            this.textBoxNumber.TabIndex = 12;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(301, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Поиск по номеру";
            // 
            // FiltrSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 686);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAddRequest);
            this.Controls.Add(this.buttonEditRequest);
            this.Controls.Add(this.dataGridViewRequests);
            this.Name = "FiltrSearch";
            this.Text = "FiltrSearch";
            this.Load += new System.EventHandler(this.FiltrSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.Button buttonEditRequest;
        private System.Windows.Forms.Button buttonAddRequest;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDeviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDefectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestStatusID;
    }
}