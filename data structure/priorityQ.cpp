#include<iostream>
#include<conio.h>
using namespace std;
int s[100],maxsize,front,rear;

void createQueue(int size)
{
	maxsize = size;
	front = 0;
	rear = -1;
}

void priority()
{
	int temp;
	for(int i=front;i<=rear;i++)
	{
		for(int j =front;j<=rear;j++)
		{
			if(s[j+1]!=0){
			
				if(s[j]>s[j+1])
			{
				temp = s[j];
				s[j] = s[j+1];
				s[j+1] = temp;
			}
			}
		}
	}
}

void EnQueue(int no)
{
	
	s[++rear] = no;
	priority();
}

int DeQueue()
{
	return s[front++];
}
int IsEmpty()
{
	if(front > rear)
		return 1;
	else
		return 0;
}
int IsFull()
{
	if(rear==maxsize-1)
		return 1;
	else
		return 0;
}

void printQueue()
{
	cout<<"\n\n";
	for(int i=front;i<=rear;i++)
	{
		cout<<"\t"<<s[i];
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