namespace Domain.ValueObject;

public abstract class BaseValueObject {
    public override bool Equals(object? obj) {
        //TODO:Реализовать DeepCompare (DeepClone)
        return base.Equals(obj);
    }

    public override int GetHashCode() {
        return base.GetHashCode();
    }
}