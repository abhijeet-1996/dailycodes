package mypackage1;
import java.util.*;
public class basicassignments1 {
	
    void asc(int arr[])
    {
    	for(int i=0;i<arr.length;i++)
        {
    		for(int j=i+1;j<arr.length;j++)
            {
            	if(arr[i]>arr[j])
            	{
            		int temp=arr[i];
            		arr[i]=arr[j];
            		arr[j]=temp;
            	}
            }
        }
    }
	public static void main(String[] args) {
		basicassignments1 b=new basicassignments1();
		int arr[];
        arr=new int[5];
        Scanner s=new Scanner(System.in);
        for(int i=0;i<arr.length;i++)
        {
        	arr[i]=s.nextInt();
        }
        b.asc(arr);
        for(int i=0;i<arr.length;i++)
        {
        	System.out.println(arr[i]);
        }
	}

}
