# UnityInventory
스파르타코딩클럽 인벤토리
Inventory System
개요
이 프로젝트는 Unity를 기반으로 한 RPG 스타일 게임에서 사용되는 캐릭터 상태(Status), 인벤토리 시스템, 그리고 장비 시스템을 구현한 예제입니다. 플레이어는 아이템을 수집하고 장착하며, 캐릭터의 능력치를 실시간으로 변화시킬 수 있습니다.

주요 기능
1. 캐릭터 시스템
Character 클래스는 닉네임, ID, 레벨, 설명 등의 메타 정보를 관리합니다.

Condition 클래스는 체력, 반응 속도, IQ, 코딩력을 포함한 능력치를 관리합니다.

ConditionController를 통해 장비 아이템의 효과를 능력치에 적용하거나 해제할 수 있습니다.

2. 인벤토리 시스템
UIInventory는 슬롯 기반 UI 인벤토리를 제공합니다.

ItemSlot은 각각의 슬롯을 담당하며, 아이템의 장착 여부를 표시합니다.

ItemData는 ScriptableObject로 정의되며, 아이템 정보와 장비 효과를 포함합니다.

3. 장비 시스템
아이템 장착 시 해당 능력치가 증가하며, 재장착 또는 해제 시 이전 효과를 제거합니다.

하나의 능력치만 변경하는 장비를 기준으로 동작합니다.

4. UI 시스템
UIMainMenu: 캐릭터 정보(닉네임, ID, 설명, 레벨 등)를 표시합니다.

UIStatus: 캐릭터의 현재 상태(체력, 반응 속도, IQ, 코딩력)를 실시간으로 업데이트합니다.

UIManager: 전체 UI를 통합적으로 제어합니다.

5. 기타
TestButton을 통해 테스트용 아이템을 무작위로 획득할 수 있습니다.

GameManager는 싱글턴으로 구현되어 플레이어 데이터를 초기화하고 UI에 전달합니다.

사용 기술
Unity C#

ScriptableObject

UI Toolkit (TextMeshPro, Button, Image 등)

싱글턴 패턴

디렉토리 구조

Assets/
├── Scripts/
│   ├── Character/
│   ├── UI/
│   ├── Inventory/
│   ├── Manager/
├── Prefabs/
├── Resources/
└── Scenes/
