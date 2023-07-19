using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PopupList
{
    public partial class Facility_register : Form
    {
        DataTable dtTemp = new DataTable();

        SqlConnection sCon = new SqlConnection(Commons.Sconnection);
        public Facility_register()
        {
            InitializeComponent();
        }
        private void Facility_register_Load(object sender, EventArgs e)
        {
            //1.그리드에 세팅이 될 데이터 테이블의 컬럼 설정.
            dtTemp.Columns.Add("m_id", typeof(string));  //장비ID
            dtTemp.Columns.Add("m_name", typeof(string));  //장비 이름
            dtTemp.Columns.Add("m_manufac", typeof(string));  //제조사
            dtTemp.Columns.Add("m_preSerMth", typeof(string));  //예방정비방법
            dtTemp.Columns.Add("m_place", typeof(string));   //설치작업장

            //2. 컬럼이 설정된 데이터 테이블을 그리드뷰에 셋팅(매핑)
            //DataSource : DataTable 의 내용을 기반으로 그리드에 행과 열의 디자인을 표현하는 속성
            Grid_Fr.DataSource = dtTemp;

            //3. 그리드에 표현될 헤더 (컬럼의 제목) 의 명칭을 설정.

            Grid_Fr.Columns["m_id"].HeaderText = " 장비 ID";
            Grid_Fr.Columns["m_name"].HeaderText = "장비 이름";
            Grid_Fr.Columns["m_manufac"].HeaderText = "제조사";
            Grid_Fr.Columns["m_preSerMth"].HeaderText = "예방정비 방법";
            Grid_Fr.Columns["m_place"].HeaderText = "설치작업장";

            // 컬럼의 폭 지정
            Grid_Fr.Columns[0].Width = 100;
            Grid_Fr.Columns[1].Width = 100;
            Grid_Fr.Columns[2].Width = 100;
            Grid_Fr.Columns[3].Width = 150;
            Grid_Fr.Columns[4].Width = 100;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //ID 값이 중복될때 밸리데이션 체크
            for (int i = 0; i < dtTemp.Rows.Count; i++)
            {
                if (dtTemp.Rows[i][0].ToString() == txt_m_id.Text ) return;
            }
            

            dtTemp.Rows.Add(txt_m_id.Text, txt_m_name.Text, txt_m_manufac.Text, cbx_m_preSerMth.Text, cbx_m_place.Text);
            txt_m_id.Clear();
            txt_m_name.Clear();
            txt_m_manufac.Clear();
            //cbx_m_place.SelectedIndex = 0;
           // cbx_m_preSerMth.SelectedIndex = 0;
            //dtTemp 행에 입력값 입력


        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //삭제 될것이 없을때 밸리데이션 체크
            if (dtTemp.Rows.Count == 0) return;

            dtTemp.Rows[Grid_Fr.CurrentCell.RowIndex].Delete(); //그리드에서 선택된 셀 제거
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //sql 일괄 업데이트 로직
        }

       
    }
}
