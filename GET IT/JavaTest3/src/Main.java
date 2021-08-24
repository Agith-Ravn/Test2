import java.util.Scanner;

public class Main {
	public static void main (String[] args) {
		
        var sverreMagnus = new Person() 
        		.setId(1) 
        		.setFirstName("Sverre Magnus") 
        		.setBirthYear(2005);
        
        var ingridAlexandra = new Person()
        		.setId(2)
        		.setFirstName("Ingrid Alexandra")
        		.setBirthYear(2004);
        
        var haakon = new Person()
        		.setId(3)
        		.setFirstName("Haakon Magnus")
        		.setBirthYear(1973);
        
        var metteMarit = new Person()
        		.setFirstName("Mette-Marit")
        		.setBirthYear(1973);
        
        var marius = new Person()
        		.setFirstName("Marius")
        		.setLastName("Borg Høiby")
        		.setBirthYear(1997);
        
        var harald = new Person()
        		.setFirstName("Harald")
        		.setBirthYear(1937);
        
        var sonja = new Person()
        		.setId(7)
        		.setFirstName("Sonja")
        		.setBirthYear(1937);
        
        var olav = new Person()
        		.setId(8)
        		.setFirstName("Olav")
        		.setBirthYear(1903);

        sverreMagnus.father = haakon;
        sverreMagnus.mother = mettevMarit;
        ingridAlexandra.father = haakon;
        ingridAlexandra.mother = metteMarit;
        marius.mother = metteMarit;
        haakon.father = harald;
        haakon.mother = sonja;
        harald.father = olav;

        Person[] persons = {sverreMagnus, ingridAlexandra, haakon,
                metteMarit, marius, harald, sonja, olav};
        
        var app = new FamilyApp(persons);
        
        System.out.println(app.WelcomeMessage());
        Scanner scanner = new Scanner(System.in);
        
        while (true)
        {
        	System.out.println(app.CommandPrompt());        	       	
            var command = scanner.nextLine();
            var response = app.HandleCommand(command);
            System.out.println(response);
        }
	}
}
