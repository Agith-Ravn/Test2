import java.io.Console;

public class Main {

	public static void main (String[] args) {
		//System.out.println("Hello world!");
		
		Console console = System.console();
		if (console != null) {
			console.writer().println("We have a console!");
		} else {
			System.out.println("We do not have a console!");
		}
	}
}
