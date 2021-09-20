#program to display Fibonacci series
n=int(input("Enter the number: "))
a=0
b=1
if n>=0:
    print(a)
    print(b)
    for i in range(0,n):
        c=a+b
        print(c)
        a=b
        b=c
else:
    print("Invalid number")
