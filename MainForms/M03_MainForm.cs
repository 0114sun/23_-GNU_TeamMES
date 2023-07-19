using FormList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    public partial class M03_MainForm : Form
    {
        Thread thread_NowDate;

        public M03_MainForm()
        {
            InitializeComponent();
        }
        public M03_MainForm(string sUsername )
        {
            InitializeComponent();
            stsUserName.Text= sUsername;
        }

        #region <폼 load>
        private void M03_MainForm_Load(object sender, EventArgs e)
        {
            //메인화면이 오픈이 될때.
            //1. timer 를 이용하여 스레드 생성
            //timNowDate.Enabled = true;

            //2. Thread 클래스를 통하여 스레드 생성
            //Thread 
            //프로세스 내부에서 생성되는 메인 처리 흐름과는 별개의 흐름(프로세스)
            //추가 함으로서 하나의 프로세스외에 여러가지 일을 동시에 수행하는 기능. (비동기)

            //2-1. 스레드가 실행 할 메서드 설정.
            ThreadStart StartThread = new ThreadStart(TimeShow);

            //2-2. 델리게이트를 실행할 Thread 클래스 생성.
            thread_NowDate = new Thread(StartThread);

            //2-3. 스레드 시작.
            thread_NowDate.Start();
        }
        #endregion

        #region <Thread Method>
        private void timNowDate_Tick(object sender, EventArgs e)
        {
            //Timer 이용한 방법.
            //Interval 1000 (1초간격으로 실행할로직)
            //현재 일시를 나타내기.
            stsNowDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void TimeShow()
        {
            //스레드가 실행할 로직.
            while (true)
            {
                Thread.Sleep(1000);
                stsNowDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
        #endregion


        #region <종료 버튼 클릭>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit(); //응용프로그램의 종료
        }

        private void M03_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //프로그램이 종료될때.
            //1. 프로그램 종료 여부를 확인.
            DialogResult Result =  MessageBox.Show("프로그램을 종료 하시겠습니까?","프로그램종료",MessageBoxButtons.YesNo);
            if (Result == DialogResult.No)
            {
                e.Cancel= true;
                return;
            }
            //2. 프로그램 종료여부의 결과가 Yes 인경우.
            // 구동 되고 있는 스레드를 종료. 
            if (thread_NowDate.IsAlive) thread_NowDate.Abort();
           
        }



        #endregion

        private void BaseM_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //기준정보 리스트에 있는 메뉴 클릭 할 경우.
            #region < 메뉴의 클래스를 일일히 호출해야하는경우>
            //if(e.ClickedItem.Name == "ItemMaster") 
            //{
            //    tabMyTab.AddForm(new ItemMaster());

            //    //사용자 정의 컨트롤을 이용하여 호출하는 화면의 클래스를 페이지로 표현

            //}
            //else if (e.ClickedItem.Name == "UserMaster")
            //{
            //    tabMyTab.AddForm(new UserMaster());
            //}

            //메뉴에서 호출해야하는 클래스(윈폼화면) 가 증가할수록 로직이 길어지고 유지보수 떨어짐
            #endregion

            #region <메뉴의 Name 문자열을 가지고 있는 클래스를 호출할 경우>

            //이미 탭페이지에 등록 되어 있는 화면을 메뉴에서 선택한 경우
            //해당 탭 페이지 활성화
            //그렇지 않을경우 탭페이지에 추가하여 탭컨트롤에 표현.

            for (int i =0; i < tabMyTab.TabPages.Count; i++)
            {
                if (tabMyTab.TabPages[i].Name == e.ClickedItem.Name)
                {
                    //탭페이지의 이름과 메뉴의 이름이 같다 (등록된페이지를 활성화)
                    tabMyTab.SelectedTab = tabMyTab.TabPages[i];
                    return;
                }
            }




            //Assembly : 프로젝트 (dll) 파일의 클래스를 추출하고 관리할수 있는 클래스.

            //DLL 파일이 있는 위치를 찾기.
            //Application.StartupPath : 응용프로그램이 실행되는 위치  \\ = \   C:\windows\
            Assembly assem = Assembly.LoadFrom(Application.StartupPath + "\\" + "FormList.DLL");
            
            //Type : 파일형식으로 되어있는 클래스 유형을 winform 형식의 Form 클래스로 변경 시켜주는 클래스.
            Type typeForm = assem.GetType("FormList." + e.ClickedItem.Name.ToString(),true);

            //파일에서 추출한 클래스를 Form 형싱으로 변형.

            Form ShowForm = (Form)Activator.CreateInstance(typeForm);

            //추출한 클래스를 Form 형식으로 만든후 TabControl에 추가.
            tabMyTab.AddForm(ShowForm);
            #endregion
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // 닫기 버튼을 클릭시 기능.
            if (tabMyTab.TabPages.Count == 0) return;
            tabMyTab.SelectedTab.Dispose();
            
        }

        private void WorkSend_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tabMyTab.TabPages.Count; i++)
            {
                if (tabMyTab.TabPages[i].Name == WorkSend.Name)
                {
                    //탭페이지의 이름과 메뉴의 이름이 같다 (등록된페이지를 활성화)
                    tabMyTab.SelectedTab = tabMyTab.TabPages[i];
                    return;
                }
            }

            //Assembly : 프로젝트 (dll) 파일의 클래스를 추출하고 관리할수 있는 클래스.

            //DLL 파일이 있는 위치를 찾기.
            //Application.StartupPath : 응용프로그램이 실행되는 위치  \\ = \   C:\windows\
            Assembly assem = Assembly.LoadFrom(Application.StartupPath + "\\" + "FormList.DLL");

            //Type : 파일형식으로 되어있는 클래스 유형을 winform 형식의 Form 클래스로 변경 시켜주는 클래스.
            Type typeForm = assem.GetType("FormList." + WorkSend.Name , true);

            //파일에서 추출한 클래스를 Form 형싱으로 변형.

            Form ShowForm = (Form)Activator.CreateInstance(typeForm);

            //추출한 클래스를 Form 형식으로 만든후 TabControl에 추가.
            tabMyTab.AddForm(ShowForm);
        }

        private void PlanManage_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tabMyTab.TabPages.Count; i++)
            {
                if (tabMyTab.TabPages[i].Name == PlanManage.Name)
                {
                    //탭페이지의 이름과 메뉴의 이름이 같다 (등록된페이지를 활성화)
                    tabMyTab.SelectedTab = tabMyTab.TabPages[i];
                    return;
                }
            }

            //Assembly : 프로젝트 (dll) 파일의 클래스를 추출하고 관리할수 있는 클래스.

            //DLL 파일이 있는 위치를 찾기.
            //Application.StartupPath : 응용프로그램이 실행되는 위치  \\ = \   C:\windows\
            Assembly assem = Assembly.LoadFrom(Application.StartupPath + "\\" + "FormList.DLL");

            //Type : 파일형식으로 되어있는 클래스 유형을 winform 형식의 Form 클래스로 변경 시켜주는 클래스.
            Type typeForm = assem.GetType("FormList." + PlanManage.Name, true);

            //파일에서 추출한 클래스를 Form 형싱으로 변형.

            Form ShowForm = (Form)Activator.CreateInstance(typeForm);

            //추출한 클래스를 Form 형식으로 만든후 TabControl에 추가.
            tabMyTab.AddForm(ShowForm);
        }

        private void RealTimeMonitor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tabMyTab.TabPages.Count; i++)
            {
                if (tabMyTab.TabPages[i].Name == RealTimeMonitor.Name)
                {
                    //탭페이지의 이름과 메뉴의 이름이 같다 (등록된페이지를 활성화)
                    tabMyTab.SelectedTab = tabMyTab.TabPages[i];
                    return;
                }
            }

            //Assembly : 프로젝트 (dll) 파일의 클래스를 추출하고 관리할수 있는 클래스.

            //DLL 파일이 있는 위치를 찾기.
            //Application.StartupPath : 응용프로그램이 실행되는 위치  \\ = \   C:\windows\
            Assembly assem = Assembly.LoadFrom(Application.StartupPath + "\\" + "FormList.DLL");

            //Type : 파일형식으로 되어있는 클래스 유형을 winform 형식의 Form 클래스로 변경 시켜주는 클래스.
            Type typeForm = assem.GetType("FormList." + RealTimeMonitor.Name, true);

            //파일에서 추출한 클래스를 Form 형싱으로 변형.

            Form ShowForm = (Form)Activator.CreateInstance(typeForm);

            //추출한 클래스를 Form 형식으로 만든후 TabControl에 추가.
            tabMyTab.AddForm(ShowForm);
        }

        private void FacilityManage_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tabMyTab.TabPages.Count; i++)
            {
                if (tabMyTab.TabPages[i].Name == FacilityManage.Name)
                {
                    //탭페이지의 이름과 메뉴의 이름이 같다 (등록된페이지를 활성화)
                    tabMyTab.SelectedTab = tabMyTab.TabPages[i];
                    return;
                }
            }

            //Assembly : 프로젝트 (dll) 파일의 클래스를 추출하고 관리할수 있는 클래스.

            //DLL 파일이 있는 위치를 찾기.
            //Application.StartupPath : 응용프로그램이 실행되는 위치  \\ = \   C:\windows\
            Assembly assem = Assembly.LoadFrom(Application.StartupPath + "\\" + "FormList.DLL");

            //Type : 파일형식으로 되어있는 클래스 유형을 winform 형식의 Form 클래스로 변경 시켜주는 클래스.
            Type typeForm = assem.GetType("FormList." + FacilityManage.Name, true);

            //파일에서 추출한 클래스를 Form 형싱으로 변형.

            Form ShowForm = (Form)Activator.CreateInstance(typeForm);

            //추출한 클래스를 Form 형식으로 만든후 TabControl에 추가.
            tabMyTab.AddForm(ShowForm);
        }

        private void FacilityWarning_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tabMyTab.TabPages.Count; i++)
            {
                if (tabMyTab.TabPages[i].Name == FacilityWarning.Name)
                {
                    //탭페이지의 이름과 메뉴의 이름이 같다 (등록된페이지를 활성화)
                    tabMyTab.SelectedTab = tabMyTab.TabPages[i];
                    return;
                }
            }

            //Assembly : 프로젝트 (dll) 파일의 클래스를 추출하고 관리할수 있는 클래스.

            //DLL 파일이 있는 위치를 찾기.
            //Application.StartupPath : 응용프로그램이 실행되는 위치  \\ = \   C:\windows\
            Assembly assem = Assembly.LoadFrom(Application.StartupPath + "\\" + "FormList.DLL");

            //Type : 파일형식으로 되어있는 클래스 유형을 winform 형식의 Form 클래스로 변경 시켜주는 클래스.
            Type typeForm = assem.GetType("FormList." + FacilityWarning.Name, true);

            //파일에서 추출한 클래스를 Form 형싱으로 변형.

            Form ShowForm = (Form)Activator.CreateInstance(typeForm);

            //추출한 클래스를 Form 형식으로 만든후 TabControl에 추가.
            tabMyTab.AddForm(ShowForm);
        }
    }
}
