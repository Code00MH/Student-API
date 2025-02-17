namespace crudAPI {
    public static class StudentRoute {
        public static void AddStudent (this WebApplication app) {
            app.MapGet("StudentTest", () => new Student("test"));
        }
    }
}
