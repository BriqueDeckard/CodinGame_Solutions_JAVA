package bd.notes.framework.model.entities;

import javax.persistence.*;
import java.util.HashSet;
import java.util.Set;

@Entity
@Table(name = "DEPARTMENT", uniqueConstraints = {@UniqueConstraint(columnNames = {"DEPT_NO"})})
public class Department {
    private Integer deptId;
    private String deptNo;

    private String deptName;
    private String location;

    private Set<Employee> employees = new HashSet<Employee>();

    public Department() {
    }

    public Department(Integer deptId, String deptNo, String deptName, String location, Set<Employee> employees) {

        this.deptId = deptId;
        this.deptNo = deptNo;
        this.deptName = deptName;
        this.location = location;
        this.employees = employees;
    }

    @Id
    @Column(name = "DEPT_ID")
    public Integer getDeptId() {
        return deptId;
    }

    public void setDeptId(Integer deptId) {
        this.deptId = deptId;
    }

    @Column(name = "DEPT_NO", length = 20, nullable = false)
    public String getDeptNo() {
        return deptNo;
    }

    public void setDeptNo(String deptNo) {
        this.deptNo = deptNo;
    }

    @Column(name = "DEPT_NAME", nullable = false)
    public String getDeptName() {
        return this.deptName;
    }

    public void setDeptName(String deptName) {
        this.deptName = deptName;
    }

    @Column(name = "LOCATION")
    public String getLocation() {
        return this.location;
    }

    public void setLocation(String location) {
        this.location = location;
    }

    public Set<Employee> getEmployees() {
        return this.employees;
    }

    public void setEmployees(Set<Employee> employees) {
        this.employees = employees;
    }
}
