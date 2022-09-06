
namespace assignment0;
public class Assignment0Class {

public Assignment0Class () {

}
public bool isLeapYear(int year){
if (year%400 == 0){
    return true;
}
else if (year%4 == 0 && year%100 != 0){
    return true;
}
else return false;

}
}
