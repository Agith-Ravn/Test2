import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class FamilyApp {

	private List<Person> allPeople;
	
	public FamilyApp(Person[] allPeopleArray) {
			
		allPeople = Arrays.asList(allPeopleArray);
				
	}
	
    public String WelcomeMessage()
    {
        return "Kommandoer: \n \"hjelp\" = viser en hjelpetekst som forklarer alle kommandoene" +
               "\n \"liste\" = lister alle personer med id, fornavn, fødselsår, dødsår og navn og" +
               " id på mor og far. \n \"vis <id>\" = viser en bestemt person med mor, far og barn.";
    }
    
    public String CommandPrompt()
    {
        return "Skriv en kommando: ";
    }
    
    public String HandleCommand(String command)
    {
    	var expectedResponse = "";
        if (command.equals("hjelp"))
        {
            expectedResponse = WelcomeMessage();
        }
        
        else if (command.equals("liste"))
        {
            for (var person : allPeople)
            {
                expectedResponse += person.GetDescription() + "\n";
            }
        }
        
        else if (command.contains(" "))
        {
        	String[] command2 = command.split(command);
        	System.out.println(command2[0]);
        	int id = Integer.parseInt(command2[1]);
        	System.out.println(id);
        	for (var person : allPeople)
        	{
        		if (id == person.id)
        		{
        			expectedResponse += person.GetDescription() + "\n";
        			if (getChildren(person).length != 0)
        			{
        				expectedResponse += "  Barn:\n";
        				for(var child : getChildren(person))
                        {
                            expectedResponse += "    " + child.firstName + " (Id=" + child.id +") Født: " + child.birthYear + "\n";
                        }
        			}
        		}
        	}
        }
        
        else
        {
            expectedResponse = "Ugydlig kommando.. prøv igjen";
        }
        
        
        return expectedResponse;
    }

	public Person[] getChildren(Person parent) {
		ArrayList<Person> children = new ArrayList<Person>();
		for(var person : allPeople)
		{
			if (person.father == parent || person.mother == parent)
			{
				children.add(person);
			}
		}
		Person[] children2 = (Person[]) children.toArray();
		return children2;
	}
}
