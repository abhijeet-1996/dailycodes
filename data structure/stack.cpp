#include <iostream>
#include <conio.h>
using namespace std;

int s[100];
int tos = -1;
int size;

int isFull()
{
    if(tos == size-1)
		return 1;
	else 
		return 0;
}
int isEmpty()
{
	if(tos == -1)
		return 1;
	else 
		return 0;
}
void push(int no)
{
    if(size==0)
    {
	cout<<"enter the size of stack you want \n\n";
	cin>>size;
    }
    if(isFull())
    cout<<"stack is full\n\n";
    else
    {
	s[size];
	tos++;
	s[tos] = no;
    }
}

void printStack()
{
	if(isEmpty())
		cout<<"\n stack is empty\n\n";
	else
	{
		for(int i=tos;i>=0;i--)
			cout<<s[i]<<"\t";
		cout<<"\n\n";
	}
}
int atTop()
{
		return s[tos];
}
int pop()
{
	int temp;
	temp = s[tos];
	tos--;
	return temp;
}

int main()
{
	int choice;
	do{
	cout<<"Select which operation you want to perform\n 1 \t push \n 2 \t pop \n 3 \t atTop \n 4 \t printStack \n Enter '0' to exit \n\n";   
	cin>>choice;
	
	switch(choice)
	{
	case 1:
		int no;
		cout<<"Enter element to add inside the stack \n";
		cin>>no;
		push(no);
		break;

	case 2:
		if(isEmpty())
		{
			cout<<"stack is empty\n\n";
		}
		else
		{
			cout<<"\n"<<pop()<<"\n\n";
		}
		break;

	case 3:
		if(isEmpty())
		{
			cout<<"stack is empty\n\n";
		}
		else
		{
		cout<<"\n"<<atTop()<<"\n\n";
		}
		break;

	case 4:
		printStack();
		break;

	dafault:
		cout<<"\n you entered wrong choice\n\n";
	}
	}
	while(choice);
	getch();
    return 0;
}