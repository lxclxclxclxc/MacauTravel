class Registrar():
    students = set()
    
    def register(self, student):
        self.students.add(student)
    
    def unregister(self, student):
        self.students.discard(student)

    def send_notifications(self, message):
        for student in self.students:
            student.notify(message)

class Student():
    def __init__(self, studentname):
        self.studentname = studentname

    def notify(self, message):
        print(self.studentname + ' received message: ' + message)


class RegistrarTeacher():
    teachers = set()
    
    def register(self, teacher):
        self.teachers.add(teacher)
    
    def unregister(self, teacher):
        self.teachers.discard(teacher)

    def send_notifications(self, message):
        for teacher in self.teachers:
            teacher.notify(message)

class Teacher():
    def __init__(self, teachername):
        self.teachername = teachername

    def notify(self, message):
        print(self.teachername + ' received message: ' + message)