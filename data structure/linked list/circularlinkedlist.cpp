#include<iostream>
#include<string.h>
#include<conio.h>
using namespace std;

struct node
{
	int data;
	struct node *next;
};
class linkedlist{
public:
	struct node *root,*last;
	void createList()
	{
		root = last = NULL;
	}
	
	void insertL(int d)
	{
		node *n = new node;
		n->data = d;
		n->next = NULL;

		if(root==NULL)
		{
			root = last = n;
			last->next = root;
		}
		else
		{
			n->next = root;
			root = n;
            last = n->next;
            last->next = root;
		}
	}
	void insertR(int d)
	{
		node *t=root;
		node *n = new node;
		n->data = d;
		n->next = NULL;

		if(root==NULL)
		{
			root = last = n;
            last->next = root;
		}
		else
		{
			last->next = n;
            last = n;
            last->next = root;
		}
	}
	void deleteL()
	{
		if(root==NULL)
			cout<<"\nEmpty List\n";
		else
		{
		node *t;
		t = root;
		cout<<"removing"<<t->data<<"\n\n";
		root = root->next;
        last->next = root;
		delete(t);
		}
	}
	void deleteR()
	{
		if(root==NULL)
			cout<<"\nEmpty List\n";
		else
		{
		node *t;
		t = root;
		if(t->next==root)
		{
			cout<<"removing"<<t->data<<"\n\n";
			delete(t);
			root = NULL;
		}
		else
		{
		while(t->next->next!=root)
		{
			t = t->next;
		}
		cout<<"removing"<<t->next->data<<"\n\n";
        last = t;
		delete(t->next);
		last->next = root;
		}}
	}
	void print()
	{
		node *t=root;
		if(root==NULL)
			cout<<"\nEmpty\n";
		else
		{
		do
		{
			if(t->next==root){
				cout<<t->data<<"\n";
				t = t->next;
			}
			else{
			cout<<t->data<<" --> ";
			t = t->next;}
		}while(t!=root);
		}
	}
	
};
int main()
{
	linkedlist l;
	l.createList();
	int choice;
	do{
	cout<<"Select which operation you want to perform\n 1 \t insert left \n 2 \t insert right \n 3 \t Delete Left \n 4 \t Delete Right \n 5 \t print \n \n Enter '0' to exit \n\n";   
	cin>>choice;
	
	switch(choice)
	{
	case 1:
		int no;
		cout<<"Enter element to add inside list \n";
		cin>>no;
		l.insertL(no);
		break;

	case 2:
		int no1;
		cout<<"Enter element to add inside list \n";
		cin>>no1;
		l.insertR(no1);
		break;
	case 3:
		l.deleteL();
		break;

	case 4:
		l.deleteR();
		break;

	case 5:
		l.print();
		break;

	dafault:
		cout<<"\n you entered wrong choice\n\n";
	}
	}
	while(choice);
}