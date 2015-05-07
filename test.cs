using System;

public class test{
	static void Main(string[] args){
		Console.Write("hello");
		Node test=new Node();

	}
}

public class Node{
	public string Value;
	public Node next;
	public Node previous;

	// Node(Node n, Node p){
	// 	this.Next= n;
	// 	this.Previous= p;
	// }

	public void Reveal(){
		Console.Write(this.Value);
	}
}
public class DList{
	public Node head;
	public Node tail;
	public DList (Node head=null){
		this.head=null;
		this.tail=head;
	}

	public void Add(Node input){
		this.tail.next=input;
		input.previous=this.tail;
		this.tail=input;
	}
}

