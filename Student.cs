namespace crudAPI {
    public class Student {
        public Guid Id { get; init; }
        public string Name { get; private set; }
        public bool Online { get; private set; }

        public Student (string name) {
            Id = Guid.NewGuid ();
            Name = name;
            Online = true;
        }
    }
}
