# GatherClone

내일 배움 캠프 Unity기초 개인 과제 GatherClone

<br/>

## 1. [ControllerEvent](https://github.com/kksoo0131/GatherClone/tree/main/Assets/Scripts/ControllEvent)

Controller의 Event를 구독할 기능들 이다.

gameObject에 Controller, ControllerEvent, PlayerInput(InputSystem)를 컴포넌트로 추가하면

gameObject가 InputSystem의 입력에 따라서 이벤트에 연결된 메서드가 실행된다.

<br/>

## 2. [Controller](https://github.com/kksoo0131/GatherClone/tree/main/Assets/Scripts/Controller)

InputSystem으로 부터 받은 값으로 이벤트를 호출한다.

<br/>

## 3. [Manager](https://github.com/kksoo0131/GatherClone/tree/main/Assets/Scripts/Manager)

싱글톤으로 만든 Manager들이다. 담당한 역할별로 분할했다.

<br/>

## 4. [UI](https://github.com/kksoo0131/GatherClone/tree/main/Assets/Scripts/UI)

각각의 UI 프리펩들이 가질 UI 클래스들이다.

모든 UI는 UI클래스를 상속받고, UIManager를 통해서 생성, 호출한다.

각각의 UI 프리펩들과 같은 이름으로 1:1로 만들었다.

<br/>

## 5. [Unit](https://github.com/kksoo0131/GatherClone/tree/main/Assets/Scripts/Unit)

Unit클래스를 상속받은 클래스들이다.

Npc에는 Npc의 대사가, Player에는 Npc와의 대화 범위 감지 메서드가 포함되어 있다.

<br/>

## 6. [Utils](https://github.com/kksoo0131/GatherClone/tree/main/Assets/Scripts/Utils)

전체적으로 사용될 수 있는 클래스들을 모아놓으려고 했는데

Enum들을 모아둔 Enums.cs 밖에 없다.
