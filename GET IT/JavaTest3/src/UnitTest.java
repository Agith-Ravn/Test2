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

}
