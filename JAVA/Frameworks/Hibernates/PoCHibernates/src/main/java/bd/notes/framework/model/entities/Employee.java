package bd.notes.framework.model.entities;

import javax.persistence.*;
import java.util.Date;
import java.util.HashSet;
import java.util.Set;

@Entity
@Table(name = "EMPLOYEE", uniqueConstraints = {@UniqueConstraint(columnNames = {"EMP_NO"})})
public class Employee {
    private Long empId;
    private String empNo;

    private String empName;
    private String job;
    private Employee manager;
    private Date hireDate;
    private Float salary;
    private byte[] image;

    private Department department;
    private Set<Employee> employees = new HashSet<Employee>(0);

    public Employee() {
    }

    public Employee(Long empId, String empNo, String empName, String job, Employee manager, Date hideDate, Float salary, byte[] image, Department department, Set<Employee> employees) {
        this.empId = empId;
        this.empNo = empNo;
        this.empName = empName;
        this.job = job;
        this.manager = manager;
        this.hireDate = hideDate;
        this.salary = salary;
        this.image = image;
        this.department = department;
        this.employees = employees;
    }

    @Id
    @Column(name = "EMP_ID")
    public Long getEmpId() {
        return empId;
    }

    public void setEmpId(Long empId) {
        this.empId = empId;
    }

    @Column(name = "EMP_NO", length = 20, nullable = false)
    public String getEmpNo() {
        return empNo;
    }

    public void setEmpNo(String empNo) {
        this.empNo = empNo;
    }

    @Column(name = "EMP_NAME", length = 50, nullable = false)
    public String getEmpName() {
        return empName;
    }

    public void setEmpName(String empName) {
        this.empName = empName;
    }

    @Column(name = "EMP_JOB", length = 30, nullable = false)
    public String getJob() {
        return job;
    }

    public void setJob(String job) {
        this.job = job;
    }

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "MNG_ID")
    public Employee getManager() {
        return manager;
    }

    public void setManager(Employee manager) {
        this.manager = manager;
    }

    @Column(name = "HIRE_DATE", nullable = false)
    @Temporal(TemporalType.DATE)
    public Date getHireDate() {
        return hireDate;
    }

    public void setHireDate(Date hireDate) {
        this.hireDate = hireDate;
    }

    @Column(name = "SALARY", nullable = false)
    public Float getSalary() {
        return salary;
    }

    public void setSalary(Float salary) {
        this.salary = salary;
    }

    @Column(name = "IMAGE", length=11111111, nullable = true)
    @Lob
    public byte[] getImage() {
        return image;
    }

    public void setImage(byte[] image) {
        this.image = image;
    }

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "DEPT_ID", nullable = false)
    public Department getDepartment() {
        return department;
    }

    public void setDepartment(Department department) {
        this.department = department;
    }
    @OneToMany(fetch = FetchType.LAZY)
    public Set<Employee> getEmployees() {
        return employees;
    }

    public void setEmployees(Set<Employee> employees) {
        this.employees = employees;
    }
}
