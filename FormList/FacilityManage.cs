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
    public partial class FacilityManage : BaseChildForm
    {

        DataTable dtTemp = new DataTable();
        public FacilityManage()
        {
            InitializeComponent();
        }

        private void btn_register_F_Click(object sender, EventArgs e)
        {
            Facility_register M01 = new Facility_register();


            M01.ShowDialog(); //모달창 ,동기식 비밀번호 변경 창 호출
                              //비밀번호 변경 창이 닫히기 전까지는 해당 메서드 로직을 수행 하지않고 기다림.
            

        }

        private void btn_edit_F_Click(object sender, EventArgs e)
        {
            //설비 등록 선택시
            Facility_edit M01 = new Facility_edit();


            M01.ShowDialog(); //모달창 ,동기식 비밀번호 변경 창 호출
                              //비밀번호 변경 창이 닫히기 전까지는 해당 메서드 로직을 수행 하지않고 기다림.
        }

        private void FacilityManage_Load(object sender, EventArgs e)
        {
            //1.그리드에 세팅이 될 데이터 테이블의 컬럼 설정.
            dtTemp.Columns.Add("m_id", typeof(string));  //장비ID
            dtTemp.Columns.Add("m_name", typeof(string));  //장비 이름
            dtTemp.Columns.Add("m_manufac", typeof(string));  //제조사
            dtTemp.Columns.Add("m_preSerMth", typeof(string));  //예방정비방법
            dtTemp.Columns.Add("m_place", typeof(string));   //설치작업장

            //2. 컬럼이 설정된 데이터 테이블을 그리드뷰에 셋팅(매핑)
            //DataSource : DataTable 의 내용을 기반으로 그리드에 행과 열의 디자인을 표현하는 속성
            Grid_FM.DataSource = dtTemp;

            //3. 그리드에 표현될 헤더 (컬럼의 제목) 의 명칭을 설정.

            Grid_FM.Columns["m_id"].HeaderText = " 장비 ID";
            Grid_FM.Columns["m_name"].HeaderText = "장비 이름";
            Grid_FM.Columns["m_manufac"].HeaderText = "제조사";
            Grid_FM.Columns["m_preSerMth"].HeaderText = "예방정비 방법";
            Grid_FM.Columns["m_place"].HeaderText = "설치작업장";
            //4. 컬럼 폭지정
            Grid_FM.Columns[0].Width = 150;
            Grid_FM.Columns[1].Width = 150;
            Grid_FM.Columns[2].Width = 150;
            Grid_FM.Columns[3].Width = 200;
            Grid_FM.Columns[4].Width = 150;
        }
    }
}
