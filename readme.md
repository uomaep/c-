# 스택 자료구조 링크드리스트, 배열로 구현하기

## 링크드 리스트로 구현한 스택 자료구조 결과 스크린샷
<img width="1648" alt="스크린샷 2023-03-22 오후 7 35 21" src="https://user-images.githubusercontent.com/114221785/226877289-005cc360-9c53-4915-af21-90d4641603dc.png">


## 배열로 구현한 스택 자료구조 결과 스크린샷
<img width="1648" alt="스크린샷 2023-03-22 오후 7 35 17" src="https://user-images.githubusercontent.com/114221785/226877534-b2b91b34-1ffc-497e-82f8-3f5f9cd53e9d.png">

# 소스 코드 설명
## 배열로 구현한 스택 자료구조 코드 설명
### 멤버 변수
<img width="202" alt="스크린샷 2023-03-27 오후 3 00 42" src="https://user-images.githubusercontent.com/114221785/227853684-a5dfe815-01d8-4f1d-aa52-992a32d7bc7a.png">
- arr: 초기 1의 크기인 배열 (스택으로 쓸 배열)
- MAXSIZE: 초기 스택의 크기
- top: 스택의 top의 index
- size: 스택의 크기

### push (데이터 삽입)
<img width="285" alt="스크린샷 2023-03-27 오후 3 04 16" src="https://user-images.githubusercontent.com/114221785/227854433-6407ea30-a433-4dd4-b1bf-109ed2da2dfa.png">
- 만약 배열이 꽉 찼다면 resize()함수를 통해 배열의 크기를 2배 늘린 후 데이터를 삽입 한다.
- size를 1증가

### resize (배열의 크기를 2배 증가)
<img width="627" alt="스크린샷 2023-03-27 오후 3 08 15" src="https://user-images.githubusercontent.com/114221785/227854843-96595eb6-999c-4112-bf5f-a9dfe3338412.png">
- arr의 배열 크기보다 2배 큰 새로운 배열을 만들고 arr의 값을 다 옮긴 후 그 배열을 arr로 만듦
- 즉, 배열의 크기를 2배 증가

### pop (데이터 삭제)
<img width="385" alt="스크린샷 2023-03-27 오후 3 10 37" src="https://user-images.githubusercontent.com/114221785/227855269-27cd5848-edb5-42ce-b558-18cdf82339fb.png">
- top index에 해당하는 부분이 가장 최근에 삽입된 데이터이므로 삭제하고 삭제한 값을 리턴해줌.

### isEmpty (스택이 비었는지 확인)
<img width="241" alt="스크린샷 2023-03-27 오후 3 14 40" src="https://user-images.githubusercontent.com/114221785/227856016-628e0418-0973-48b0-ba34-4f5ce4ef2656.png">
- size가 이면 true 리턴

### toString (인스턴스 출력 양식)
<img width="470" alt="스크린샷 2023-03-27 오후 3 19 47" src="https://user-images.githubusercontent.com/114221785/227856842-f6d2092c-8e67-4cac-b17f-6803a491a158.png">
- 스택의 담겨있는 자료를 출력하는 
