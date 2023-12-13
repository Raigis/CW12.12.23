``` mermaid
graph TD;
1(Start)-->2["array[]={''''}
              length = 0
              string"];
2-->3[/input string/];
3-->4{"string == ''''"};
4--Yes-->5{"array[0]==''''"};
5--Yes-->6["array = {''one'', ''two'', ''three'', ''four''}
                     length = 4"];
4--No-->7["array[length]=string
           length+=1"];
7-->3;
5--No-->8{{"i=0; i < length; i+=1"}};
8--Yes-->9{"array[i].Length <= 3"};
9--Yes-->10[/"output array[i]"/];
9--No-->8;
10-->8;
6-->8;
8--No-->11(Finish);
```
