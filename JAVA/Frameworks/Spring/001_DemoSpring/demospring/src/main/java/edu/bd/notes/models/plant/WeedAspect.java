import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import javax.annotation.Resource;
import org.aspectj.lang.ProceedingJoinPoint;
import org.aspectj.lang.annotation.Around;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.reflect.MethodSignature;
import org.springframework.stereotype.Component;

@Aspect
@Component
public class WeedAspect {

    /**
     * Weed that stole the food.
     */
    @Resource
    Plant weed;

    /**
     * @Around. Ce type d'advice fait une interception autour de la méthode qui
     * allait être appelée sur l'objet cible, et empêche son exécution. Le flux peut
     * aussi être intercepté avant ou après l'invocation du point de jonction (avec
     * les annotations @Before et @After).
     * 
     * Un point de jonction est trouvé quand l'invocation d'une méthode correspond à
     * un point de coupe.
     * 
     * Le point de coupe est défini avec l'expression execution(* nourri*(..)) &&
     * bean(*Malade) qui décrit que l'advice sera exécuté quand une méthode qui
     * retourne n'importe quel type de valeur ayant comme préfixe nourri est
     * invoquée sur un bean avec un id ayant comme suffixe le mot Malade.
     * 
     * @param joinPoint
     * @throws IllegalAccessException
     * @throws InvocationTargetException
     */
    @Around("execution(* feed*(..)) && ben(*Malade*)")
    public void weedAdvice(final ProceedingJoinPoint joinPoint)
            throws IllegalAccessException, InvocationTargetException {

        // We know that the intended object is a plant
        Plant plant = (Plant) joinPoint.getTarget();

        // We know that the JoinPoint is a method
        Method method = ((MethodSignature) joinPoint.getSignature()).getMethod();

        System.out.println("    * Weed feels the method " + method.getName() + " on " + plant.getPlantName());

        // What the right plant was going to receive is received by the weed
        method.invoke(weed, joinPoint.getArgs());

    }
}
