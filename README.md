# basic-wpf-2024
IoT 개발자 WPF 학습 리포지토리

## 1일차 (2024-04-29)
- WPF(Window Presentation Foundation) 기본학습
    - Winforms 확장한 WPF
        - 이전의 WinForms는 이미지 비트맵 방식(2D)
        - WPF 이미지 벡터방식
        - XAML 화면 디자인 - 안드로이드 개발시 JAVA XML로 화면디자인과 PyQt로 디자인과 동일

    - XAML(엑스에이엠엘, 재물)
        - 여는 태그 <Window>, 닫는 태그 </Window>
        - 합치면 <Window /> - Window 태그 안에 다른 객체가 없다는 뜻
        - 여는 태그와 닫는 태그 사이에 다른 태그(객체)를 넣어서 디자인

    - WPF 기본 사용법
        - Winforms와는 다르게 코딩으로 디자인을 함

    - 레이아웃
            - 1. Grid - WPF에서 가장 많이 쓰는 대표적인 레이아웃 
            - 2. Canvas - 미술에서 캔버스와 유사
            - 3. StackPanel - 스택으로 컨트롤을 쌓는 레이아웃
            - 4. DockPanel - 컨트롤을 방향에 따라서 도킹시키는 레이아웃
            - 5. Margin - 여백기능, 앵커링 같이함(중요!)

## 2일차(2024-04-30)
- WPF 기본학습
    - 데이터 바인딩 : 데이터소스(DB, 엑셀, txt, 클라우드에 보관된 데이터 원본)의 데이터를 쉽게 가져다 쓰기 위한 데이터 핸들링 방법
        - 데이터와 개발을 분리하려면 '데이터 바인딩' 뿐이다.
        - xaml : {Binding Path = 속성, ElementName = 객체, Mode=(OneWay|TwoWay), StringFormat, StringFormat = {0:#,#}}
        - dataContext : 데이터를 담아서 전달하는 이름
        - 전통적인 윈폼 코드비하인드에서 데이터를 처리하는 것을 지양 - 디자인, 개발 부분 분리

## 3일차(2024-05-02)
- WPF에서 중요한 개념 (윈폼과의 차이)
    1. 데이터 바인딩
        - 바인딩 키워드로 코드와 분리
    2. 옵저버 패턴 - 값이 변경된 사실을 사용자에게 공지 OnPropertyChanged 이벤트
    3. 디자인 리소스 - 각 컨트롤 마다 디자인(X), 리소스로 디자인을 공유
        - 각 화면당 Resources - 자기 화면에만 적용되는 디자인
        - App.xaml Resources - 애플리케이션 전체에 적용되는 디자인
        - 리소스 사전 - 공유할 디자인 내용이 많을 때 파일로 따로 지정

- WPF MVM
    - MVC(Model View Controller 패턴)
        - 웹개발(Spring, ASP.NET MVC, dJango, etc ...) 현재도 사용되고 있음
        - Model : Data 입출력 처리를 담당, View에 제공할 데이터
        - View : 디스플레이 화면 담당, 순수 xaml로만 구성
        - Controller : View를 제어, Model 처리 중앙에 관장

    - MVVM(Model View ViewModel)
        - Model : Data 입출력 처리를 담당(DB site), View에 제공할 데이터...
        - View : 화면, 순수 xaml로만 구성
        - ViewModel : 뷰에 대한 메서드, 액션, INotifyPropertyF Changed를구현
    
    ![MVVM패턴](https://raw.githubusercontent.com/c9yu/basic-wpf-2024/main/imgs/wpf001.png)
        
    - 권장 구현방법
        - ViewModel 생성, 알림 속성 구현
        - View에 View을 데이터바인딩
        - Model DB작업 독립적으로 구현

    - MVM 구현 도와주는 프레임워크
        0. 3rd Party 개발, 2008년부터 시작 2014년도 이후 더이상개발이나 지원이 없음
        1. **Caliburn** - 3rd Party 개발. MVM이 아주 간단, 강력. 중소형 프로젝트에 적합. 디버깅이 조금 어려움
        2. AvaoniaUI 
            - 3rd Party 개발
            - 크로스 플랫폼
            - 디자인은 최고
        3. Prism - Microsoft 개발. 무지막지하게 어렵다. 대규모 프로젝트 활용

- Caliburn Micro
    1. 프로젝트 생성 후MainDwidwo
    2. Models, Views, ViewModels 폴더(네임 스페이스)     
    3. 종속성 NuGet패키지 Caliburn.Micro 설치
    4. 루트 폴더에 StartupUir 삭제
    5. App.xaml에서 StartupUri 삭제
    6. App.xaml에 Bootstrapper 클래스를 리소스사전에 등록
    7. App.xaml.cs에 App() 생성자 추가
    8. ViewModels 폴더에 MainViewModel.cs 클래스 생성
    9. Bootstrapper.cs에 onstartup()에 내용을 변경
    10. View 폴더에 MainView.xaml 만들기                                                                                                  

    - 작업 분리 (3인으로 분리)
        - DB 개발자 - DBMS 테이블 생성, Models에 클래스 작업
        

- WPF의 기본 학습
    - 옵저버 패턴
    - 디자인 리소스

## 4일차 (2024-05-03)
- Caliburn.Micro
    - 작업 분리
        - Xaml디자이너 - xaml 파일만 디자인
        - ViewModel 개발자 - Model에 있는 DB 관련정보와 View와 연계 전체구현 작업

    - Caliburn.Micro 특징
        - Xaml 디자인시 {Binding ...} 잘 사용하지 않음
        - 대신 x:Name을 사용

    - MVVM 특징
        - 예외발생 시 예외 메시지 표시없이 프로그램 종료
            - 이 경우 무조건 디버깅 해야함
        - ViewModel에서 디버깅 시작
        - View.xaml 바인딩, 버튼클릭 이름(ViewModel 속성, 메서드) 지정 주의
        - Model 내 속성 DB 테이블 컬럼 이름 일치, CRUD 쿼리문 오타 주의
        - ViewModel 부분
            - 변수, 속성으로 분리
            - 속성이 Model내의 속성과 이름이 일치
            - List 사용불가 -> BindableCollection으로 변경
            - 메서드와 이름이 동일한 Can... 프로퍼터 지정, 버튼 활성/비활성화
            - 모든 속성에 NotifyofPropertyChange() 메서드 존재!! (값 변경 알림)



    ![실행화면](https://raw.githubusercontent.com/c9yu/basic-wpf-2024/main/imgs/wpf002.png)

## 5일차 (2024-05-07)
- Caliburn.Micro + MahApps.Metro
    - Metro(Modern UI) 디자인 접목

    ![실행화면](https://raw.githubusercontent.com/c9yu/basic-wpf-2024/main/imgs/wpf004.png)

    ![실행화면](https://raw.githubusercontent.com/c9yu/basic-wpf-2024/main/imgs/wpf003.png)

- Movie API 연동 앱, MovieFinder 2024
    - 좋아하는 영화 즐겨찾기 앱
    - DB(SQLServer) 연동
    - MahApps,Metro UI
    - Cefsharp WebBrowser 패키지
    - Google.Apis 패키지
    - Newtonsoft.Json 패키지
    - OpenAPI, 두가지 사용
    - MVVM은 사용X
    - [themoviedb.org](https://www.themoviedb.org/) openAI 활용
    - [Youtube API](https://console.cloud.google.com/) 활용
    - 새 프로젝트 생성
    - API 및 서비스, 라이브러리 선택
    - YouTube Data API v3 선택, 사용버튼 클릭
    - 사용자 인증 정보 만들기 클릭
        - 사용자 데이터 라디오 버튼 클릭 -> 다음 클릭
        - OAuth 동의화면, 기본내용 입력 후 다음
        - 범위는 손대지 않고 저장 후 계속
        - OAuth 클라이언트 ID, 앱 유형을 데스크톱 앱, 이름 입력 후 만들기

## 6일차 (2024-05-08)
- MovieFinder 2024 계속 진행
    - 즐겨찾기 후 다시 선택 즐겨찾기 막아야 함
    - 즐겨찾기 삭제 구현
    - 선택 목록 중 일부만 즐겨찾기 목록에 저장하는 기능 추가
    - 그리드뷰 영화를 더블클릭하면 영화소개 팝업

## 7일차 (2024-05-09)
- MovieFinder 2024 완료

- 데이터포털 API 연동앱 예제
    - CefSharp 사용시 플랫폼 대상 AnyCPU에서 x64로 변경 필수!
    - 개인 프로젝트 참조소스

## 8일차 (2024-05-)
- WPF 개인프로젝트 포트폴리오 작업
    - 데이터포털 API 사용할 것
    - 7일차 소스 참조
    - 현재 리포지토리에 사진과 함께 올릴 것

    - 부산광역시 인구수 확인 프로그램
        - 목표
            - 1. MahApps,Metro UI 사용 
            - 2. 부산 광역시의 구 별 인구를 Open Api를 통해 받아와 출력
            - 3. '그래프' 버튼을 클릭하면 받아온 데이터를 통해 막대 그래프를 그리기    

        - 결과
            - 1. MahApps,Metro UI 사용 
                - 보다 깔끔한 UI를 위해 MahApps, Metro UI 사용 (구현)

            - 2. 부산 광역시의 구 별 인구를 Open Api를 통해 받아와 출력 (구현)
                - 공공 데이터 포털에서 필요한 Open Api를 탐색한다.
                - 활용을 신청한 뒤 승인이 나면 인증키를 통해 인증을 진행한 뒤 사용한다.
                - '실시간 조회' 버튼을 클릭하면 Open Api를 통해 받아온 데이터를 바인딩하여 Gridbox에 출력한다.

            - 3. '그래프' 버튼을 클릭하면 받아온 데이터를 통해 막대 그래프를 그리기 (미구현)
                - '그래프' 버튼을 클릭하면 새로운 창이 출력되면서 Open Api에서 받아온 값들의 컬럼명(임의로 지정한)이 우측 리스트박스에 출력된다. (구현)
                - 해당 값들 중 하나를 선택하면 좌측에 막대그래프 형태로 출력된다. (미구현)
            
        - 고찰
            - 지금까지 수업과 프로젝트를 진행하며 한번도 그래프를 사용해 본 적이 없어 배워보기 전 
              미리 경험해본다는 생각으로 이전에 배웠던 Open Api와 결합해 그래프를 넣어보고자 했다.

            - 1. 처음엔 LiveCharts를 사용해 그래프를 그려보려 했지만 오류가 잦고, 제대로 동작하지 않아 다른 방법을 찾아보았다.
            - 2. 이전에 받은 데이터(경도, 위도)를 구글 맵으로 넘겨 특정 지점을 출력하였듯이 그래프를 그려주는 사이트에 해당 값들을 넘겨 출력할 방법은 없는지 확인해보았으나
                 마찬가지로 넘겨야 할 값들이 많고, 구현하기에 무리가 있음을 확인하였다.
            
            - 따라서 다음 단계의 진행은 추후 관련 수업 이후 진행한다.


            
https://github.com/c9yu/basic-wpf-2024/assets/158007438/da585c41-164a-4831-8d65-6ba909cbeb36
