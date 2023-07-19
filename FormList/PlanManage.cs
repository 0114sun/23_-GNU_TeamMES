
using Calendar.NET;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormList
{
    public partial class PlanManage : BaseChildForm
    {
        public PlanManage()
        {
            InitializeComponent();

            var TaeukTestEvent = new CustomEvent
            {
                Date = new DateTime(2023,7,18,12,0,0),
                RecurringFrequency = RecurringFrequencies.EveryMonWedFri,
                EventLengthInHours = 2,
                EventText = "A장비 소모품 교체"
            };
            myCalendar.AddEvent(TaeukTestEvent);

            var TestEvent = new CustomEvent
            {
                Date = new DateTime(2023, 7, 18, 18, 0, 0),
                RecurringFrequency = RecurringFrequencies.Daily,
                EventLengthInHours = 1,
                EventText = "테스트",
                EventColor = Color.Green
                
            };

            myCalendar.AddEvent(TestEvent);
        }
        

    }
}
