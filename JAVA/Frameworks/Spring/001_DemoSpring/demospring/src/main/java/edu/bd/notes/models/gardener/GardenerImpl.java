package main.java.edu.bd.notes.models.gardener;

public class GardenerImpl implements Gardener {

    private String nom;

    public String getNom() {
        return this.nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String toString() {
        return "Gardener: " + nom;
    }
}
