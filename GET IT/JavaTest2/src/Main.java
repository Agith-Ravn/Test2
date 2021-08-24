import java.util.Scanner;

public class Main {
	
	public static void main (String[] args) {
		System.out.println("Skriv noe her..");
		Scanner scanner = new Scanner(System.in);
		String string = scanner.nextLine();
		System.out.println("Du skrev: " + string);
	}
}
