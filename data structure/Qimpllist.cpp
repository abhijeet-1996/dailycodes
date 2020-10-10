#include<iostream>
#include<string.h>
#include<conio.h>
using namespace std;

struct node
{
	int data;
	node * next;
};
class Qimpl{

public:
	node *front;
	node *rear;
	void createList()
	{
		front = NULL;
		rear = NULL;
	}
	void EnQueue(int no)
	{
		node *t=rear;
		node *n = new node;
		n->data = no;
		n->next = NULL;

		if(rear==NULL)
		{
			rear = front = n;
		}
		else
		{
			rear->next = n;
			rear = n;
		}
	}
	void DeQueue()
	{
		if(front==NULL)
			cout<<"\nEmpty Stack\n";
		else
		{
		node *t;
		t = front;
		cout<<"removing"<<t->data<<"\n\n";
		front = front->next;
		delete(t);
		}
	}
	void print()
	{
		node *t=front;
		if(front==NULL)
			cout<<"\nEmpty Stack\n";
		else
		{
		while(t!=NULL)
		{
			if(t->next==NULL){
				cout<<t->data<<"\n";
				t = t->next;
			}
			else{
			cout<<t->data<<" --> ";
			t = t->next;}}
		}
	}
};
int main()
{
	Qimpl s;
	int choice;
	s.createList();
	do{
	cout<<"Select which operation you want to perform\n 1 \t EnQueue \n 2 \t DeQueue \n 3 \t PrintSQ \n  \n Enter '0' to exit \n\n";   
	cin>>choice;
	
	switch(choice)
	{
	case 1:
		
		int no;
		cout<<"Enter element to add inside the stack \n";
		cin>>no;
		s.EnQueue(no);
		break;

	case 2:
		s.DeQueue();
		break;
	case 3:
		s.print();
		break;

	dafault:
		cout<<"\n you entered wrong choice\n\n";
	}
	}
	while(choice);
	getch();


}