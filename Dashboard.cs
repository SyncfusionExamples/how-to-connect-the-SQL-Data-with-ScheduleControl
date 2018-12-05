using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Data.SqlClient;
using Syncfusion.Schedule;
using Syncfusion.Windows.Forms.Schedule;

namespace SFCDB
{
    public partial class Dashboard : MetroForm
    {
        SimpleScheduleDataProvider dataProvider = new SimpleScheduleDataProvider();
        SimpleScheduleAppointmentList list = new SimpleScheduleAppointmentList();

        string ConnectionString = @"Data Source=SYNCLAPN6099\SQLEXPRESS;Initial Catalog=ScheduleData;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        public Dashboard()
        {
            InitializeComponent();
            ReadData();
            dataProvider.MasterList = list;
            scheduleControl1.ScheduleType = ScheduleViewType.Month;
            scheduleControl1.DataSource = dataProvider;        
        }

        private void ReadData()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            string sql = "select * from ScheduleData";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ScheduleAppointment item = new ScheduleAppointment();
                item.UniqueID = (int)dr["UniqueID"];
                item.Subject = (string)dr["Sub"];
                item.StartTime = (DateTime)dr["StartTime"];
                item.ReminderValue = (int)dr["ReminderValue"];
                item.Reminder = false;
                item.Owner = (int)dr["Own"];
                item.MarkerValue = (int)dr["MarkerValue"];
                item.LocationValue = (string)dr["LocationValue"];
                item.LabelValue = 0;
                item.EndTime = (DateTime)dr["EndDate"];
                item.Content = (string)dr["Content"];
                item.AllDay = false;

                item.Dirty = false;
                list.Add(item);
            }
        }


    }
}
