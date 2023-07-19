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
using Services;

namespace MainForms
{
    public partial class M02_PWChange : Form
    {
        public M02_PWChange()
        {
            InitializeComponent();
        }

        private void btnPWChange_Click(object sender, EventArgs e)
        {
            //비밀번호 변경 버튼을 클릭
            string sUserid = txtUserId.Text;     //입력한 사용자 ID
            string sNowPw = txtNowPW.Text;       //입력한 현재비밀번호
            string sChangePW = txtChangePW.Text; //입력한 변경 할 비밀번호

            #region <밸리데이션 체크>
            string sMessage = string.Empty;     //누락 값존재시 입력될 에러 메세지
            if (sUserid == "") sMessage += "아이디";
            else if (sNowPw == "") sMessage += "현재 비밀번호";
            else if (sChangePW == "") sMessage += "변경 할 비밀번호";

            if (sMessage != string.Empty)
            {
                MessageBox.Show($"{sMessage}를 입력하지 않았습니다");
                return;
            }
            #endregion

            #region <비밀번호 변경을 할수있는 ID 와 PW 인지 확인.>
            //

            //1. DB 주소 
            
            string Sconnection = Commons.Sconnection;
            //string Sconnection = "Server = PC-094\\MSSQLSERVER01; Uid = sa; Pwd = 1234; database = AppDev;";
            //2. 데이터베이스 오픈.

            SqlConnection connection = new SqlConnection(Sconnection);
            try
            {
                connection.Open();

                //3. 데이터 베이스에 전달할 명령

                string sSqlSelect = $"SELECT * FROM TB_USER WHERE USERID ='{sUserid}' AND PW = '{sNowPw}'";
                                
                //4.데이터베이스 전달객체에 설정.

                SqlDataAdapter adapter = new SqlDataAdapter(sSqlSelect, connection);

                //5.데이터베이스에 실행 및 결과 반환.
                DataTable dtTemp = new DataTable ();
                adapter.Fill (dtTemp);

                //6. 결과 값이 존재 하지 않을경우 비밀번호 변경 실패
                if (dtTemp.Rows.Count ==0)
                {
                    MessageBox.Show("사용자 ID와 비밀번호가 일치하지 않습니다");
                    return;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //DB닫기
                connection.Close();
            }
            #endregion


            #region<비밀번호 변경 로직 적용>
            //변경내용 적용여부 확인하기.
            DialogResult result = MessageBox.Show("비밀번호 변경내역을 저장하시겠습니까?", "비밀번호 변경", MessageBoxButtons.YesNo);
            if (result == DialogResult.Cancel) return;
            //아래랑 같은코드
            //if (MessageBox.Show("비밀번호 변경내역을 저장하시겠습니까?", "비밀번호 변경", MessageBoxButtons.YesNo) == DialogResult.Cancel) return;


            try
            {
                connection.Open ();

                //1. 데이터베이스 의 데이터를 갱신(추가 , 삭제 , 수정) 을 할수 있는 클래스.
                SqlCommand cmd = new SqlCommand();

                //2. 커맨드 객체가 실행해야 할 데이터 베이스 주소...

                cmd.Connection = connection;

                //3. SQL 명령 문 작성 . 

                string sSqlupdate = $"UPDATE TB_USER                   " +
                                    $"  SET PW      = '{sChangePW}',   " +
                                    $"     EDITDATE = '{string.Format("{0:yyyy-MM-dd HH:mm:ss}" , DateTime.Now)}' " +
                                    $" WHERE USERID = '{sUserid}'      ";

                //4. SQL 명령 문 커맨드에 등록. 
                cmd.CommandText = sSqlupdate;

                //5. 명령 실행.

                cmd.ExecuteNonQuery();

                MessageBox.Show("정상적으로 비밀번호를 변경하였습니다.");

                this.Visible = false; //메모리 상주해있으나 눈에는안보임
                this.Close(); // 비밀번호 변경 클래스에서 더이상 실핼할 로직이 없을 경우 화면을 종료(모달상태를 해제)
            }
            catch ( Exception ex )
            {
                MessageBox.Show (ex.ToString());
            }
            finally
            {
                connection.Close ();
            }

            #endregion
        }
    }
}
