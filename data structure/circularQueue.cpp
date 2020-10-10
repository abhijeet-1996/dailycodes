#include<iostream>
#include<conio.h>
using namespace std;
int s[100],maxsize,front,rear,cn=0;

void createQueue(int size)
{
	maxsize = size;
	front = 0;
	rear = -1;
}

void EnQueue(int no)
{
	cn++;
	rear = (rear +1)% maxsize;
	s[rear] = no;
	
}

int DeQueue()
{
	cn--;
	int temp = s[front];
	front = (front +1)% maxsize;
	return temp;
}
int IsEmpty()
{
	if(cn==0)
		return 1;
	else
		return 0;
}
int IsFull()
{
	if(cn==maxsize)
		return 1;
	else
		return 0;
}

void printQueue()
{
	int i=front,c=0;
	cout<<"\n\n";
	while(c<cn)
	{
		cout<<s[i]<<"\t";
		i=(i+1)%maxsize;
		c++;
	}
	cout<<"\n\n";
}
int main()
{
	int n,choice;
	cout<<"enter the size Queue";
	cin>>n;
	createQueue(n);

	do{
	cout<<"Select which operation you want to perform\n 1 \t EnQueue \n 2 \t DeQueue \n 3 \t PrintQueue \n  \n Enter '0' to exit \n\n";   
	cin>>choice;
	
	switch(choice)
	{
	case 1:
		if(IsFull())
		{
			cout<<"\n Queue is full\n";
		}
		else{
		int no;
		cout<<"Enter element to add inside the Queue \n";
		cin>>no;
		EnQueue(no);}
		break;

	case 2:
		if(IsEmpty())
		{
			cout<<"Queue is empty\n\n";
		}
		else
		{
			cout<<"\n"<<DeQueue()<<"\n\n";
		}
		break;
	case 3:
		printQueue();
		break;

	dafault:
		cout<<"\n you entered wrong choice\n\n";
	}
	}
	while(choice);
	getch();
}