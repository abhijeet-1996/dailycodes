#include<iostream>
#include<string.h>
#include<conio.h>
using namespace std;

struct node
{
	int data;
	node * next;
};
class stackimpl{

public:
	node *tos;
	void createList()
	{
		tos = NULL;
	}
	void push(int no)
	{
		node *n = new node;
		n->data = no;
		n->next = NULL;

		if(tos==NULL)
		{
			tos = n;
		}
		else
		{
			n->next = tos;
			tos = n;
		}
	}
	void pop()
	{
		if(tos==NULL)
			cout<<"\nEmpty Stack\n";
		else
		{
		node *t;
		t = tos;
		cout<<"removing"<<t->data<<"\n\n";
		tos = tos->next;
		delete(t);
		}
	}
	void print()
	{
		node *t=tos;
		if(tos==NULL)
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
	stackimpl s;
	int choice;
	s.createList();
	do{
	cout<<"Select which operation you want to perform\n 1 \t push \n 2 \t pop \n 3 \t PrintStack \n  \n Enter '0' to exit \n\n";   
	cin>>choice;
	
	switch(choice)
	{
	case 1:
		
		int no;
		cout<<"Enter element to add inside the stack \n";
		cin>>no;
		s.push(no);
		break;

	case 2:
		s.pop();
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