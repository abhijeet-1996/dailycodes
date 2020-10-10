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
	struct node *root;
	void createList()
	{
		root = NULL;
	}
	
	void insertL(int d)
	{
		node *n = new node;
		n->data = d;
		n->next = NULL;

		if(root==NULL)
		{
			root = n;
		}
		else
		{
			n->next = root;
			root = n;
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
			root = n;
		}
		else
		{
			t=root;
			while(t->next!=NULL)
			{
				t = t->next;
			}
			t->next = n;
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
		if(t->next==NULL)
		{
			cout<<"removing"<<t->data<<"\n\n";
			delete(t);
			root = NULL;
		}
		else
		{
		while(t->next->next!=NULL)
		{
			t = t->next;
		}
		cout<<"removing"<<t->next->data<<"\n\n";
		delete(t->next);
		t->next = NULL;
		}}
	}
	void print()
	{
		node *t=root;
		if(root==NULL)
			cout<<"\nEmpty\n";
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
	void search(int no)
	{
		node *t = root;
		int count =1;
		while(t!=NULL && t->data!=no)
		{
			t = t->next;
			count++;
		}
		if(t!=NULL)
		{
			cout<<"\nfound at pos "<<count<<"\n";
		}
		else
		{
			cout<<"\nNot found\n";
		}
	}
	void deleteAtpos(int no)
	{
		node *t = root;
		node *t1;
		int count =1;
		while(t!=NULL && t->data!=no)
		{
			t1 = t;
			t = t->next;
			count++;
		}
		if(t!=NULL)
		{
			t1->next = t->next;
			cout<<"removing"<<t->data<<"\n\n";
			delete(t);
		}
		else
		{
			cout<<"\nNot found\n";
		}
	}
};
int main()
{
	linkedlist l;
	l.createList();
	int choice;
	do{
	cout<<"Select which operation you want to perform\n 1 \t insert left \n 2 \t insert right \n 3 \t Delete Left \n 4 \t Delete Right \n 5 \t print \n 6 \t Search \n 7 \t Delete at position \n \n Enter '0' to exit \n\n";   
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

	case 6:
		int no2;
		cout<<"Enter element to add inside list \n";
		cin>>no2;
		l.search(no2);
		break;

	case 7:
		int no3;
		cout<<"Enter element to add inside list \n";
		cin>>no3;
		l.deleteAtpos(no3);
		break;

	dafault:
		cout<<"\n you entered wrong choice\n\n";
	}
	}
	while(choice);
}