import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

import junit.framework.Assert;

class UnitTest {

	@Test
    public void TestAllFields()
    {
		Person father = new Person( 23, "Per" );
		Person mother = new Person( 29, "Lise" );
		
        Person p = new Person(        
            17,
            "Ola",
            "Nordmann",
            2000,
            3000,
            father,
            mother
        );

        var actualDescription = p.GetDescription();
        var expectedDescription = "Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";

        assertEquals(expectedDescription, actualDescription);
    }
	
	@Test
    public void TestAllFields2()
    {
		Person f = new Person( 23, "Per" );
		Person m = new Person();
		
        Person p = new Person() 
        {{       
            id = 17;
            firstName = "Ola";
            lastName = "Nordmann";
            birthYear = 2000;
            deathYear = 3000;
            father = f;
            mother = m;
        }};

        var actualDescription = p.GetDescription();
        var expectedDescription = "Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23)";

        assertEquals(expectedDescription, actualDescription);
    }
	
	@Test
    public void TestNoFields()
    {
		
        Person p = new Person().setId(1);
     

        var actualDescription = p.GetDescription();
        var expectedDescription = "(Id=1)";

        assertEquals(expectedDescription, actualDescription);
    }
	
	@Test
	public void Test()
    {
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
        
        var harald = new Person() 
        		.setId(6)
        		.setFirstName("Harald")
        		.setBirthYear(1937);
        
        sverreMagnus.father = haakon;
        ingridAlexandra.father = haakon;
        haakon.father = harald;

        Person[] persons = {sverreMagnus, ingridAlexandra, haakon};
        
        var app = new FamilyApp(persons);
        var actualResponse = app.HandleCommand("vis 3");
        var expectedResponse = "Haakon Magnus (Id=3) Født: 1973 Far: Harald (Id=6)\n"
               + "  Barn:\n"
               + "    Sverre Magnus (Id=1) Født: 2005\n"
               + "    Ingrid Alexandra (Id=2) Født: 2004\n";
        assertEquals(expectedResponse, actualResponse);
    }

}
