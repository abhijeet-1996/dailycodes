#include<iostream>
#include<string.h>
#include<conio.h>
using namespace std;

struct node
{
	int data;
	struct node *left;
    struct node *right;
};
class Dlinkedlist{
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
		n->left = NULL;
        n->right = NULL;

		if(root==NULL)
		{
			root = n;
		}
		else
		{
			n->right = root;
            root->left = n;
			root = n;
		}
	}
	void insertR(int d)
	{
		node *t=root;
		node *n = new node;
		n->data = d;
		n->left = NULL;
        n->right = NULL;
		if(root==NULL)
		{
			root = n;
		}
		else
		{
			while(t->right!=NULL)
			{
				t = t->right;
			}
			t->right = n;
            n->left = t;
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
		root = root->right;
		if(root!=NULL)
        root->left = NULL;
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
		if(t->right==NULL)
		{
			cout<<"removing"<<t->data<<"\n\n";
			delete(t);
			root = NULL;
		}
		else
		{
		while(t->right->right!=NULL)
		{
			t = t->right;
		}
		cout<<"removing"<<t->right->data<<"\n\n";
		delete(t->right);
		t->right = NULL;
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
			if(t->right==NULL){
				cout<<t->data<<"\n";
				t = t->right;
			}
			else{
			cout<<t->data<<" --> ";
			t = t->right;}}
		}
	}
    void revprint()
	{
		node *t=root;
		if(root==NULL)
			cout<<"\nEmpty\n";
		else
		{
            while(t->right!=NULL)
            {
				t = t->right;
            }
            while(t!=NULL)
            {
                if(t->left==NULL){
                    cout<<t->data<<"\n";
                    t = t->left;
                }
                else{
                cout<<t->data<<" --> ";
                t = t->left;
                }
            }
        }
	}
};
int main()
{
	Dlinkedlist l;
	l.createList();
	int choice;
	do{
	cout<<"Select which operation you want to perform\n 1 \t insert left \n 2 \t insert right \n 3 \t Delete Left \n 4 \t Delete Right \n 5 \t print \n 6 \t reverse print \n  \n \n Enter '0' to exit \n\n";   
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
		l.revprint();
		break;

	dafault:
		cout<<"\n you entered wrong choice\n\n";
	}
	}
	while(choice);
}