1- [22,27,16,2,18,6] -> Insertion Sort

a) Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.
b) Big-O gösterimini yazınız.
c) Time Complexity: Average case: Aradığımız sayının ortada olması,Worst case: Aradığımız sayının sonda olması, Best case: Aradığımız sayının dizinin en başında olması.
d) Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer? Yazınız.

CEVAP:

a) [2,27,16,22,18,6]
[2,6,16,22,18,27]
[2,6,16,18,22,27]

b) O(n^2) Her seferinde en küçük elemanı başa alıp kalanlar üzerinden işlem yaptığımız için; n+(n-1)+(n-2)+...+1 olacak şekilde her adımda bu kadar eleman içerisinden küçüğünü alıyoruz.
Yukarıdaki ifadenin toplamı da (n*(n+1))/2 den (n^2 + n)/2 gelir. Burada baskın olan n^2 olduğu için Big-O gösterimi O(n^2) olur.

c) Best Case: 2
Average Case: 16,18
Worst Case: 27

d) Average Case

2- [7,3,5,8,2,9,4,15,6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.

CEVAP:

[2,3,5,8,7,9,4,15,6]
[2,3,4,8,7,9,5,15,6]
[2,3,4,5,7,9,8,15,6]
[2,3,4,5,6,9,8,15,7]
