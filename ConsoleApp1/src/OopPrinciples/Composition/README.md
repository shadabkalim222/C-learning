# Composition

Composition invovles creating complex objects by combining simpler objects or compoennts. In composition, objects are assembled together to form larger sturctures, wtih each component object maintaining its own state and beahvior. Composition is often described in terms of a "has-a" relationship.

## Composition vs Inheritance

When to use Composition:
1) When you need more flexibility in constructing objects by assembling smaller, resuable componnets.
2) When there is no clear "is-a" relationship between classes, and a "has-a" relationship is more appropriate. 
3) When you want to avoid the limitations of inheritance, such as tight coupling and the fragile base class problem - which we will look into shortly.
   

When to use Inheritance:
1) When there is a clear "is-a" relationship between classes, and subclass objects can be treated as instances of their superclass.
2) When you want to promote code reuse by inherting properties and behaviors from existing classes.
3) When you want to leverage polymorphism to allow objects of different subclasses to be treated uniformly thorugh their common superclass interface.