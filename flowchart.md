::: mermaid
flowchart TB
1(Start)--->2["enter_array[]={''''}
              answer_array[]
              length_enter = 0
              length_answer = 0
              string"]--->3[/"input string"/]--->4{"string==''''"}--Yes-->5{"array[0]==''''"}--Yes-->6["array = {one, two, three, four}
                                                                                                        length = 4"]
4--Noo-->7["array[length_enter]=string
           length_enter+=1"]--->3
5--Noo-->8{{i=0; i < length_enter; i+=1}}--Yes-->9{"enter_array[i].Length <= 3"}--Yes-->10["answer_array[length_answer] = enter_array[i]
length_answer+=1"]--->8
9--Noo-->8
6--->8
8--Noo-->11{{i = 0; i < length_answer; i+=1}}--Yes-->12[/"output answer[i]"/]-->11
11--Noo-->13(Finish)