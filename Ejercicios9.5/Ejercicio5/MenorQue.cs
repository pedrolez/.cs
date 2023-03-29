public class MenorQue : ICumplePredicado<float>
{
    public bool Predicado(float tem1, float tem2) => tem1 < tem2;
}