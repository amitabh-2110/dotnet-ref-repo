
namespace CSharpCourse._3Oops;

// interfaces are not like an abstract concept like an abstract class, rather interface follows "behaves like" relationship between classes.
// interfaces defines a contract, if a class inherits from an interface it has to implement those behaviour.
// a class can inherits from more than one interface at a time unlike inheritance.
// interfaces are used to contain declaration of methods and properties.
// e.g. Bird and Plane are not related but the behaviour of flying is common between these two, so we can create a base type IFly for these two types.

public interface ILearnInterface
{

}

public interface IFlyable
{
    void Fly(); // implicitly virtual
}