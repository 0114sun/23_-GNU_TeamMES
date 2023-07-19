using PopupList;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormList
{
    public partial class WorkSend : BaseChildForm
    {
        public WorkSend()
        {
            InitializeComponent();
            // dateTimePicker 형식을 간략하게 변환
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd dddd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd dddd";
        }

        private void btn_WorkSend_register_Click(object sender, EventArgs e)
        {
            //설비 등록 선택시
            WorkSend_register M01 = new WorkSend_register();


            M01.ShowDialog(); //모달창 ,동기식 비밀번호 변경 창 호출
                              //비밀번호 변경 창이 닫히기 전까지는 해당 메서드 로직을 수행 하지않고 기다림.
        }

        private void btn_WorkSend_edit_Click(object sender, EventArgs e)
        {
            //설비 등록 선택시
            WorkSend_edit M01 = new WorkSend_edit();


            M01.ShowDialog(); //모달창 ,동기식 비밀번호 변경 창 호출
                              //비밀번호 변경 창이 닫히기 전까지는 해당 메서드 로직을 수행 하지않고 기다림.
        }
    }
}
