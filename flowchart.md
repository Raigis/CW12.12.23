::: mermaid
flowchart TB
1(Start)--->2["array[]={''''}
              length = 0
              string"]--->3[/"input string"/]--->4{"string==''''"}--Yes-->5{"array[0]==''''"}--Yes-->6["array = {one, two, three, four}
                                                                                                        length = 4"]
4--Noo-->7["array[length]=string
           length+=1"]--->3
5--Noo-->8{{i=0; i < length; i+=1}}--Yes-->9{"array[i].Length <= 3"}--Yes-->10[/"output array[i]"/]--->8
6-->8
8--Noo-->11(Finish)
:::