# Hopfield_Network_wtih_winform
교수님이 영상처리부분을 공부하면서 차량 번호판 인식부분을 보게 되었다. 차량 번호판 인식에 흥미를 느끼게 되었고 차량 번호판 인식에 기초가 되는 홉필드 네트워크를 알게 되었다. 
이 프로젝트에서는 홉필드 네트워크를 통해서 간단한 글자인식을 만들었다.
## 개발목표
1. 정확히 글자를 입력했을 시 완전히 글자를 인식한다.
2. 글자를 대충 입력했을 시 어느정도 글자를 인식한다.
3. 글자를 이상한 입력을 했을 시 글자를 인식안하고 에러라고 뜬다.
## 실행화면
### 프로그램 기능
1) 학습 패턴에 양극화 적용
2) 학습 패턴에 대한 홉필드 네트워크 가중치 계산 후 저장<br>
   - 가중치 계산식<br>
   <img src="https://user-images.githubusercontent.com/23256819/123587564-6da54480-d821-11eb-8011-87e72f5aaf26.png"></img>
3) 입력 된 값에 가중치를 이용해서 학습을 한다.
   - 입력된 값 x 가중치 = B
   - B를 아래 식을 통해서 극대화 (B가 0보다 크면 1, 0보다 작으면 0)<br>
   <img src="https://user-images.githubusercontent.com/23256819/123587560-6c741780-d821-11eb-8221-128ddaf2fd52.PNG"></img>
   - 이 값을 통해서 학습 패턴 중 하나라도 일치하면 종료, 아니면 3과정을 반복
### 실행화면
실행 시작 화면
<img src="https://user-images.githubusercontent.com/23256819/123587547-68e09080-d821-11eb-8a94-15f36fb14281.PNG"></img>
<br>
5x5 박스에 날려쓴 글씨를 입력시 오른쪽에 표시를 함.
아래 이미지는 ㄱ을 날려쓴 이미지를 입력, 오른쪽에는 ㄱ으로 표시함
<img src="https://user-images.githubusercontent.com/23256819/123587549-6a11bd80-d821-11eb-9bd1-c543ffba93c9.PNG"></img><br>
아래 이미지는 ㄴ을 날려쓴 이미지를 입력, 오른쪽에는 ㄴ으로 표시함
<img src="https://user-images.githubusercontent.com/23256819/123587561-6d0cae00-d821-11eb-9c1f-f4cae1f4c690.PNG"></img><br>
아래 이미지는 ㄷ을 날려쓴 이미지를 입력, 오른쪽에는 ㄷ으로 표시함
<img src="https://user-images.githubusercontent.com/23256819/123587562-6d0cae00-d821-11eb-8af1-1f29162c3411.PNG"></img>

