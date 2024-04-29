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
    - 디자인, C# 코드 완전분리 개발 - MVVM 디자인패턴 (요즘 많이 씀. 근데 엄청 어려움)
    - 디자인 코딩 방법