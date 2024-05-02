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

    - MVM(Model View ViewModel)
        - Model : Data 입출력 처리를 담당(DB site), View에 제공할 데이터...
        - View : 화면, 순수 xaml로만 구성
        - ViewModel : 뷰에 대한 메서드, 액션, INotifyPropertyF Changed를구현
        
    ![MVM 패턴]()
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

    - 작업 분리
        - DB 개발자 - DBMS 테이블 생성, Models에 클래스 작업

- WPF의 기본 학습
    - 옵저버 패턴
    - 디자인 리소스