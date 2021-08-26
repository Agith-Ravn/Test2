
public class Person {
	
	int id;
	String firstName;
	String lastName;
	int birthYear; 
	int deathYear;
	Person father;
	Person mother;
	
	public Person(int id, String firstName, String lastName, int birthYear, int deathYear, Person father, Person mother) {
		this.id = id;
		this.firstName = firstName;
		this.lastName = lastName;
		this.birthYear = birthYear;
		this.deathYear = deathYear;
		this.father = father;
		this.mother = mother;
	}
	
	public Person(int id, String firstName) {
		this.id = id;
		this.firstName = firstName;
	}
	
	public Person() {}
	
	
	//-----------
	
	public Person setId(int x) {
		this.id = x;
		return this;
	}
	
	public Person setFirstName(String x) {
		this.firstName = x;
		return this;
	}
	
	public Person setLastName(String x) {
		this.lastName = x;
		return this;
	}
	
	public Person setBirthYear(int x) {
		this.birthYear = x;
		return this;
	}
	
	public Person setDeathYeath(int x) {
		this.deathYear = x;
		return this;
	}
	
	public Person setFather(Person x) {
		this.father = x;
		return this;
	}
	
	public Person setMother(Person x) {
		this.mother = x;
		return this;
	}
	
	
	
	public String GetDescription() {
		String description = "";
		
		description += (firstName != null) ? firstName + " " : "";
		description += (lastName != null) ? lastName + " " : "";
		
		description += (id != 0) ? "(Id=" + id + ") " : "";
		
		description += (birthYear != 0) ? "Født: " + birthYear + " " : "";
		description += (deathYear != 0) ? "Død: " + deathYear + " " : "";
		
		try {
			description += (father.firstName != null) ? "Far: " + father.firstName + " " : "";
		} catch (Exception e) {
			description += "";
		}
		
		try {
			description += (father.id != 0) ? "(Id=" + father.id + ") " : "";
		} catch (Exception e) {
			description += "";
		}
		
		try {
			description += (mother.firstName != null) ? "Mor: " + mother.firstName + " " : "";
		} catch (Exception e) {
			description += "";
		}
		
		try {
			description += (mother.id != 0) ? "(Id=" + mother.id + ") " : "";
		} catch (Exception e) {
			description += "";
		}
		
		/*if (mother.firstName != null) description += "Mor: " + mother.firstName + " ";
		if (mother.id != 0) description += "(Id=" + mother.id + ") ";*/
		
		/*description += (mother.firstName != null) ? "Mor: " + mother.firstName + " " : "";
		description += (mother.id != 0) ? "(Id=" + mother.id + ") " : "";
		*/
		return description.trim();
	}
	
}
