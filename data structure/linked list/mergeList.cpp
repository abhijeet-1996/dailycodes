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

node* merge(node *r1,node *r2)
{
	node *root1=NULL,*last = NULL;
	
	while(r1!=NULL && r2!=NULL)
	{
		node *n = new node;
	if(r1->data<r2->data)
	{
		n->data = r1->data;
		r1 = r1->next;
	}
	else
	{
		n->data = r2->data;
		r2 = r2->next;
	}
		n->next = NULL;
		if(root1 == NULL)
		{
			root1 = last =n;
		}
		else
		{
			last->next = n;
			last = n;
		}
		
	}
	while(r1!=NULL)
	{
		node* n = new node;
		n->data = r1->data;
		n->next = NULL;
		last->next = n;
		last = n;
		r1 = r1->next;
	}
	while(r2!=NULL)
	{
		node* n = new node;
		n->data = r2->data;
		n->next = NULL;
		last->next = n;
		last = n;
		r2 = r2->next;
	}
	return root1;
}
int main()
{
	linkedlist l;
	l.createList();
	l.insertL(15);
	l.insertR(20);
	l.insertR(30);
	l.print();
	linkedlist l1;
	l1.createList();
	l1.insertL(10);
	l1.insertR(25);
	l1.insertR(35);
	l1.insertR(40);
	l1.print();
	node *t = merge(l.root,l1.root);
	while(t!=NULL)
	{
		if(t->next == NULL)
		{
			cout<<t->data<<"\n";
			t = t->next;
		}
		else
		{
		cout<<t->data<<" --> ";
		t = t->next;
		}
	}
	getch();
}