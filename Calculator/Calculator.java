import java.util.*;
public class Calculator {
    
    static Scanner sc = new Scanner(System.in);
    
    char sign;
    int num1, num2;
    int result = 0;

    public void addNum() {

        result = num1 + num2;
        System.out.println(result);
        return;
    }
    
    public void minusNum() {

        result = num1 - num2;
        System.out.println(result);
        return;
    }
    
    public void multiplyNum() {

        result = num1 * num2;
        System.out.println(result);
        return;
    }
    
    public void divideNum() {

        result = num1 / num2;
        System.out.println(result);
        return;
    }

    public static void main(String[] args) {

        Calculator calc = new Calculator();
        boolean choice = true;

        System.out.println("Hello!");
        System.out.println("I am a calculator.");

        while (choice = true) {
            try {
                
                System.out.println("Enter two numbers in order to start calculations.");

                calc.num1 = calc.sc.nextInt();
                calc.num2 = calc.sc.nextInt();

                System.out.println("Enter one of the following signs: +, -, *, /");
                calc.sign = calc.sc.next().charAt(0);


                switch (calc.sign) {
                    case '+':
                        calc.addNum();
                        System.out.println("");
                        break;

                    case '-':
                        calc.minusNum();
                        System.out.println("");
                        break;

                    case '*':
                        calc.multiplyNum();
                        System.out.println("");
                        break;

                    case '/':
                        calc.divideNum();    
                        System.out.println("");
                        break;

                    case 'e':
                        choice = false;
                        return;
                    
                    default:
                        System.out.println("Invalid input. Please try again.");
                        System.out.println("");
                    
                }
            }

            catch (Exception InputMismatchException) {
                System.out.println("Invalid input. Please try again.");
                sc.next();
                System.out.println("");
                continue;
            }

            System.out.println("Continue calculating?");
            char pick = sc.next().charAt(0);

            if (pick == 'y') {
                continue;
            }

            else if (pick == 'n') {
                System.out.println("Exit?");
                char exit = sc.next().charAt(0);

                if (exit == 'y') {

                    System.out.println("");
                    choice = false;
                    return;
                }

                else if (exit == 'n') {
                    System.out.println("");
                    continue;

                }

                else {
                    System.out.println("Invalid input. Please try again.");
                    System.out.println("");
                    continue;   

                }

            }
            
            else {
                System.out.println("Invalid input. Please try again.");
                System.out.println("");
                continue;   
            }
        }
    

    }
}