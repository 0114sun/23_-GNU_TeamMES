using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using Services;


namespace MainForms
{
    public partial class Form1 : Form
    {
        //2. Login 여부를 전달할 필드멤버 변수.
        //  public bool bLoginFlag = false;

        //사용자명을 전달할 클래스 변수
        //public string sUserName;
     
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender = null, EventArgs e = null) //선택적 인자
        {
            //로그인버튼 클릭시 진입점
            //밸리데이션 체크
            //개발자가 프로그램 로직을 수행하는 코딩을하기전 예외적 검출사항,정상로직이 수행되지않는조건 미리 예측코드에적용


            string sUserId = string.Empty;  //사용자 ID
            string sPassword = string.Empty; //비밀번호
            
            //사용자ID 와 PW를 정확히 입력하였는지 확인
            sUserId = txtUserId.Text;
            sPassword = txtPassword.Text;

            string Message = string.Empty;
            

            if (sUserId == "")
            {
                Message = "사용자 ID";
            }
            else if (sPassword == "")
            {
                Message += "비밀번호";
            }

            if (Message != "")
            {
                MessageBox.Show($"{Message}를 입력하지않았습니다");
                return;
            }

            //1. 로직을 수행
            
         

            string Sconnection = Commons.Sconnection;
          //  string Sconnection = "Server = PC-094\\MSSQLSERVER01; Uid = sa; Pwd = 1234; database = AppDev;";
            //2. 데이터베이스 접속 클래스
            SqlConnection Connect = new SqlConnection(Sconnection);

            //정상 데이터베이스 접속
            try
            {
                //3. 데이터베이스 오픈
                Connect.Open();
                #region <사용자 ID와 PW가 동시에 일치하는 경우로 로그인여부확인>
                ////4. 데이터베이스에 전달할 명령
                //string sSqlselect = $"SELECT * FROM TB_USER WHERE USERID = '{sUserId}' AND PW = '{sPassword}'";
                ////5. 명령을 전달할 클래스
                //SqlDataAdapter adapter = new SqlDataAdapter(sSqlselect, Connect);

                ////6. 데이터베이스 조회 수행 및 결과 반환.
                //// DataTable : C# 에서 데이터베이스의 반환결과를 할당 받을수 있는 자료구조
                //DataTable dTtemp = new DataTable();
                //adapter.Fill(dTtemp);

                ////로그인할수있는 사용자 체크
                //if (dTtemp.Rows.Count == 0)
                //{
                //    MessageBox.Show("사용자 ID 또는 비밀번호가 잘못되었습니다.");
                //    txtUserId.Text = "";
                //    txtPassword.Text = "";   //ID 비밀번호 초기화
                //    txtUserId.Focus(); //커서위치 활성화
                //    return;
                //}

                //string sDbUserId = dTtemp.Rows[0][0].ToString(); // 데이터베이스에서 받아온 사용자의 ID

                #endregion

                #region <T_사용자 ID가 일치하지 않는지 PW 가 일치하지않는지 경우를 모두 확인 후 로그인 여부 확인>
                //string sSqlselect = $"SELECT * FROM TB_USER WHERE USERID = '{sUserId}'";

                ////5. 데이터베이스 실행 객체 등록

                //SqlDataAdapter adapter = new SqlDataAdapter(sSqlselect,Connect);

                ////6. 데이터베이스에서 결과를 받아올 그릇 (table)

                //DataTable dtTemp = new DataTable(); //참조형

                ////7. 명령을 실행하고 결과를 받아오기

                //adapter.Fill(dtTemp);

                ////8.데이터테이블에 결과값이 없다. (등록된 ID X)

                //if (dtTemp.Rows.Count == 0)
                //{
                //    MessageBox.Show("사용자 ID가 존재하지 않습니다..");
                //    txtUserId.Text = "";
                //    txtPassword.Text = "";   //ID 비밀번호 초기화
                //    txtUserId.Focus(); //커서위치 활성화
                //    return;
                //}
                //else if (sPassword != dtTemp.Rows[0]["PW"].ToString())
                //{
                //    MessageBox.Show("비밀번호가 일치하지 않습니다");
                //    txtPassword.Text = "";   //ID 비밀번호 초기화
                //    txtPassword.Focus(); //커서위치 활성화
                //    return;
                //}

                //정상로그인 처리 로직.


                #endregion

                #region<1. ID 존재여부 확인, 2. ID는 일치하는데 비밀번호가 미일치, 3.ID는 일치 비밀번호 미일치시 비밀번호 오류횟수 3회 일경우 프로그램 종료> >

                //string sSqlselect = $"SELECT * FROM TB_USER WHERE USERID = '{sUserId}'";
                //SqlDataAdapter adapter = new SqlDataAdapter(sSqlselect, Connect);

                //DataTable dTtemp = new DataTable();
                //adapter.Fill(dTtemp);


                //if (dTtemp.Rows.Count == 0)
                //{
                //    MessageBox.Show("사용자ID가 잘못되었습니다.");

                //}

                //else if (sPassword != dTtemp.Rows[0][2].ToString())
                // {

                //    string count = dTtemp.Rows[0][3].ToString();

                //    MessageBox.Show("비밀번호가 일치하지 않습니다\n" + $"틀린횟수 {dTtemp.Rows[0][3].ToString()}");

                //    //3. SQL 명령 문 작성 . 
                //    //1. 데이터베이스 의 데이터를 갱신(추가 , 삭제 , 수정) 을 할수 있는 클래스.
                //    SqlCommand cmd = new SqlCommand();
                //    //2. 커맨드 객체가 실행해야 할 데이터 베이스 주소...
                //    cmd.Connection = Connect;

                //    string sSqlupdate = $"UPDATE TB_USER                   " +
                //                        $"  SET LOGIN_FAIL_CNT      = '{Fail_CNT}'   " +
                //                        $" WHERE USERID = '{sUserId}'      ";


                //    //4. SQL 명령 문 커맨드에 등록. 

                //    cmd.CommandText = sSqlupdate;


                //    //5. 명령 실행.

                //    cmd.ExecuteNonQuery();



                //            txtPassword.Text = "";   //ID 비밀번호 초기화
                //            txtPassword.Focus(); //커서위치 활성화

                //    return ;

                // }


                //MessageBox.Show($"{dTtemp.Rows[0]["USERNAME"]}님 반갑습니다.");

                //if (Fail_CNT == 3) this.Close();


                #endregion

                #region<T_solution>
                //1 . ID 가 일치하는지 확인. 
                string sSqlstring = $" SELECT USERID,   " +
                                    $"        USERNAME, " +
                                    $"        PW,       " +
                                    $"        LOGIN_FAIL_CNT" +
                                    $" FROM TB_USER     " +
                                    $" WHERE USERID = '{sUserId}'";

                SqlDataAdapter  adapter = new SqlDataAdapter(sSqlstring,Connect);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                //아이디 일치 하는지 여부
                if (dtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("ID 가  존재하지 않습니다.");
                    return;
                }
                //3. 비밀번호 3회 실패 ID일 경우 return
                else if (dtTemp.Rows[0]["LOGIN_FAIL_CNT"].ToString() == "3")
                {
                    MessageBox.Show("비밀번호를 3회 잘못입력한 ID 입니다. \r\n 관리자와 문의하세요.");
                    this.Close(); // 현재클래스를 종료 예약(모든 명령이 끝난후 종료)
                    return;
                }

                else if (sPassword != dtTemp.Rows[0]["PW"].ToString())              
                {
                    //5. 데이터베이스 에 등록되어있는 현재비밀번호 실패 횟수.
                    int iLoginF_CNT = Convert.ToInt32(dtTemp.Rows[0]["LOGIN_FAIL_CNT"])+1;

                    //6.비밀번호 오류 횟수 update
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Connect;

                    string sSqlupadte = $"UPDATE TB_USER" +
                                        $"    SET LOGIN_FAIL_CNT +=1" +
                                        $"  WHERE USERID = '{sUserId}'";

                    cmd.CommandText = sSqlupadte;
                    cmd.ExecuteNonQuery();

                    //7.실패횟수 3회일경우 종료

                    if (iLoginF_CNT ==3)
                    {
                        MessageBox.Show("비밀번호를 3회잘못입력하여 프로그램을 종료합니다.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"비밀번호를 잘못 입력해쓰  로그인 가능횟수 {3 - iLoginF_CNT}회");
                    }

                    return;
                }
                #endregion
                
                //메인메뉴를 오픈할수 있는 상태

                MessageBox.Show($"{dtTemp.Rows[0]["USERNAME"]}님 반갑습니다.");
                // Commons.bloginFlag = true;     정적변수를 이용한 로그인 결과 전달방법

                //   bLoginFlag = true;
                
                //컬렉션 Arraylist
                //List 처럼 가변적으로 데이터를 관리 할 수 있으며
                //데이터 유형에 관계없이 데이터를 담을 수있다.

                ArrayList arrayList = new ArrayList();
                arrayList.Add(true);
                arrayList.Add(dtTemp.Rows[0]["USERNAME"].ToString());

                //위의 코드는 아래처럼 간단히 구현할수 있다.
                //객체 이니셜라이징.

                //ArrayList arrayList = new ArrayList
                //{
                //    true,
                //    dtTemp.Rows[0]["USERNAME"].ToString()
                //};

                this.Tag = arrayList; 

                //sUserName = dtTemp.Rows[0]["USERNAME"].ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //2. 1도중에 예외상황 발생시
                //   (예외상황 : 프로그램 로직오류, 사용자가 임의로 예외상황 발생시키는경우)
            }
            finally
            {
                //3. try or catch ==>반드시 실행해야 하는 부분.
                Connect.Close();
            }
            
            

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // KeyEventArgs : 이벤트 메서드를 실행할때 던져주는 이벤트에 대한 속성 (키의 정보)
            //키보드의 키를 입력할때 실행되는 메서드.
            
            if (e.KeyCode == Keys.Enter)
            {
                // 로그인 기능을 수행. 
                btnLogin_Click();
            }
        }

        private void btnPWChange_Click(object sender, EventArgs e)
        {
            //비밀번호 변경 버튼 클릭시
            M02_PWChange M02 = new M02_PWChange();
            //M02.Show(); //비동기식 윈폼 클래스 창호출

            //로그인 창 잠시 숨기기.
            this.Visible = false;
            M02.ShowDialog(); //모달창 ,동기식 비밀번호 변경 창 호출
                              //비밀번호 변경 창이 닫히기 전까지는 해당 메서드 로직을 수행 하지않고 기다림.
            this.Visible = true;
            
        

        }


       
        }
    }
