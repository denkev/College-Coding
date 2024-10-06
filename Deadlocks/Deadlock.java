public class Deadlock {
    public static final Object lock1 = new Object();
    public static final Object lock2 = new Object();
    public static final Object lock3 = new Object();
    public static final Object lock4 = new Object();

    public static void main(String[] args) {

        System.out.println("Hello!");
        System.out.println("Welcome to *Moser Robotics*");
        System.out.println("Today I will show you how my");
        System.out.println("robots create a deadlock.");
        System.out.println("");
        

        Thread thread1 = new Thread(new Thread1());
        Thread thread2 = new Thread(new Thread2());
        Thread thread3 = new Thread(new Thread3());
        Thread thread4 = new Thread(new Thread4());

        thread1.start();
        thread2.start();
        thread3.start();
        thread4.start();
    }
}

class Thread1 implements Runnable {
    public void run() {
        synchronized (Deadlock.lock1) {
            System.out.println("Robot 1: Holding screws and need a Screwdriver!");
            try {
                Thread.sleep(100);
            } catch (InterruptedException e) {
                Thread.currentThread().interrupt();
            }
            synchronized (Deadlock.lock2) {
                System.out.println("Thread 1: Holding lock 2");
                try {
                    Thread.sleep(100);
                } catch (InterruptedException e) {
                    Thread.currentThread().interrupt();
                }
                synchronized (Deadlock.lock3) {
                    System.out.println("Thread 1: Holding lock 3");
                }
            }
        }
    }
}

class Thread2 implements Runnable {
    public void run() {
        synchronized (Deadlock.lock2) {
            System.out.println("Robot 2: Holding a Wrench and need screws!");
            try {
                Thread.sleep(100);
            } catch (InterruptedException e) {
                Thread.currentThread().interrupt();
            }
            synchronized (Deadlock.lock3) {
                System.out.println("Thread 2: Holding lock 3");
                try {
                    Thread.sleep(100);
                } catch (InterruptedException e) {
                    Thread.currentThread().interrupt();
                }
                synchronized (Deadlock.lock4) {
                    System.out.println("Thread 2: Holding lock 4");
                }
            }
        }
    }
}

class Thread3 implements Runnable {
    public void run() {
        synchronized (Deadlock.lock3) {
            System.out.println("Robot 3: Holding bolts and need a Wrench!");
            try {
                Thread.sleep(100);
            } catch (InterruptedException e) {
                Thread.currentThread().interrupt();
            }
            synchronized (Deadlock.lock4) {
                System.out.println("Thread 3: Holding lock 4");
                try {
                    Thread.sleep(100);
                } catch (InterruptedException e) {
                    Thread.currentThread().interrupt();
                }
                synchronized (Deadlock.lock1) {
                    System.out.println("Thread 3: Holding lock 1");
                }
            }
        }
    }
}

class Thread4 implements Runnable {
    public void run() {
        synchronized (Deadlock.lock4) {
            System.out.println("Robot 4: Holding a Screwdriver and need bolts!");
            try {
                Thread.sleep(100);
            } catch (InterruptedException e) {
                Thread.currentThread().interrupt();
            }
            synchronized (Deadlock.lock1) {
                System.out.println("Thread 4: Holding lock 1");
                try {
                    Thread.sleep(100);
                } catch (InterruptedException e) {
                    Thread.currentThread().interrupt();
                }
                synchronized (Deadlock.lock2) {
                    System.out.println("Thread 4: Holding lock 2");
                }
            }
        }
    }
}