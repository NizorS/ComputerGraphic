#include <stdlib.h>
#include <glut.h>
#include <cmath>

int curWidth = 1000;
int curHeight = 700;

void myWireSphere(GLfloat radius, int slices, int stacks) {
    glPushMatrix();
    glRotatef(-90.0, 1.0, 0.0, 0.0);
    glutWireSphere(radius, slices, stacks);
    glPopMatrix();
}

static int year = 0, day = 0;

void display() {
    glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
    glPushMatrix();

    glColor3f(1.0, 1.0, 0.0);
    myWireSphere(1.0, 15, 15);

    glRotatef((GLfloat)year, 0.0, 1.0, 0.0);
    glTranslatef(2.0, 0.0, 0.0);
    glRotatef((GLfloat)day, 0.0, 1.0, 0.0);
    glColor3f(0.0, 0.0, 1.0);
    myWireSphere(0.2, 15, 15);
    glColor3f(1, 1, 1);
    glBegin(GL_LINES);
    glVertex3f(0, -0.3, 0);
    glVertex3f(0, 0.3, 0);
    glEnd();

    glPopMatrix();
    glFlush();
    glutSwapBuffers();
}

static GLfloat u = 0.0;                 // curve parameter for comet pos
static GLfloat du = 0.1;                // amt to increment u each frame

void timer(int v) {
    u += du;
    day = (day + 1) % 360;
    year = (year + 2) % 360;
    glLoadIdentity();
    gluLookAt(20 * cos(u / 8.0) + 12, 5 * sin(u / 8.0) + 1, 10 * cos(u / 8.0) + 2, 0, 0, 0, 0, 1, 0);
    glutPostRedisplay();
    glutTimerFunc(1000 / 60, timer, v);
}

void reshape(GLint w, GLint h) {
    glViewport(0, 0, w, h);
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
    gluPerspective(60.0, (GLfloat)w / (GLfloat)h, 1.0, 40.0);
    glMatrixMode(GL_MODELVIEW);
}

int main(int argc, char** argv) 
{
    glutInit(&argc, argv);

    glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGBA | GLUT_DEPTH);
    glutInitWindowSize(curWidth, curHeight);
    glutInitWindowPosition(1440 - 2 * curWidth, 900 - 2 * curHeight);
    glutCreateWindow("Фомичев Дмитрий 3821Б1ПМмм1");

    glutDisplayFunc(display);
    glutReshapeFunc(reshape);
    glutTimerFunc(100, timer, 0);
    glutMainLoop();
}

/*#define _USE_MATH_DEFINES
#define _CRT_SECURE_NO_WARNINGS

#include <stdlib.h>
#include <math.h>
#include <glut.h>
#include "stdio.h"

int curWidth = 1000;
int curHeight = 700;
int worldSize = 100;

// Colors
GLfloat WHITE[] = { 1, 1, 1 };
GLfloat RED[] = { 1, 0, 0 };
GLfloat GREEN[] = { 0, 1, 0 };
GLfloat MAGENTA[] = { 1, 0, 1 };

int rotateOldX = worldSize + 1;
int rotateOldY = worldSize + 1;
int rotateX = 0;
int rotateY = 0;

int moveOldx = 0;
int moveOldz = 0;
int moveX;
int moveZ;

class Teapot
{
private:
    double size;
    GLfloat* color;
    double maximumDistance;
    double x;
    double y;
    double z;
    int direction;
public:
    Teapot(double s, GLfloat* c, double x, double y, double z) :
        size(s), color(c), direction(1.),
        y(y), x(x), z(z) 
    {
        maximumDistance = 10.;
    }
    void update() 
    {
        x += direction * 0.05;
        
        if (x >= maximumDistance)
        {
            x = maximumDistance;
            direction = -1.;
        }
        else if (x <= -maximumDistance)
        {
            x = -maximumDistance;
            direction = 1.;
        }

        glPushMatrix();
            glMaterialfv(GL_FRONT, GL_AMBIENT_AND_DIFFUSE, color);
            glTranslated(x, y, z);
            glutSolidTeapot(size);
        glPopMatrix();
    }
};

Teapot teapots[] = {
  Teapot(1, GREEN, -17, 0.75, 1),
  Teapot(1.5, MAGENTA, -16, 1.25, 4),
  Teapot(0.4, WHITE, -15, 0.3, 7)
};

int displayListId;

void createRamp();
void createWorld();
void init();
void display();
void reshape(GLint w, GLint h);
void timer(int v);
GLuint LoadTexture(const char* filename);
void specialKeys(int key, int x, int y);

GLuint skyBox = LoadTexture("skytexture.bmp");

int main(int argc, char** argv) {
    glutInit(&argc, argv);
    
    glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGBA | GLUT_DEPTH);
    glutInitWindowSize(curWidth, curHeight);
    glutInitWindowPosition(1440 - 2 * curWidth, 900 - 2 * curHeight);
    glutCreateWindow("Фомичев Дмитрий 3821Б1ПМмм1");

    glutDisplayFunc(display);
    glutSpecialFunc(specialKeys);
    glutReshapeFunc(reshape);
    glutTimerFunc(100, timer, 0);
    init();
    glutMainLoop();
}

void createRamp()
{
    GLfloat lightPosition[] = { 0, worldSize, 0, 1 };
    glLightfv(GL_LIGHT0, GL_DIFFUSE, lightPosition);

    glBegin(GL_QUADS);
        glTranslated(0, 0, -6);
        glutSolidCube(2);
    glEnd();
}

void createWorld()
{
    displayListId = glGenLists(1);
    glNewList(displayListId, GL_COMPILE);
    GLfloat lightPosition[] = { 0, worldSize, 0, 1 };
    glLightfv(GL_LIGHT0, GL_POSITION, lightPosition);


    glBegin(GL_QUADS);//земля
        glNormal3d(0, 1, 0);
        glColor3f(0, 0, 0);
        glVertex3d(-worldSize, 0, -worldSize);
        glVertex3d(-worldSize, 0, worldSize); //координаты
        glVertex3d(worldSize, 0, 100); // вершин
        glVertex3d(worldSize, 0, -worldSize);
    glEnd();

    glEnable(GL_TEXTURE_2D);
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_NEAREST);
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_NEAREST);
    glBindTexture(GL_TEXTURE_2D, skyBox);

    /*glBegin(GL_QUADS);//небо
        glNormal3d(0, 1, 0);
        glColor3f(0, 0, 0);
        glTexCoord2f(0, 0);  glVertex3d(-worldSize, worldSize, -worldSize);
        glTexCoord2f(1, 0);  glVertex3d(worldSize, worldSize, -worldSize); //координаты
        glTexCoord2f(1, 1);  glVertex3d(worldSize, worldSize, worldSize); // вершин
        glTexCoord2f(0, 1);  glVertex3d(-worldSize, worldSize, worldSize);
    glEnd();

    glBegin(GL_QUADS);//стена
        glColor3f(0, 0, 0);
        glVertex3d(-worldSize, 0, -worldSize);
        glVertex3d(-worldSize, worldSize, -worldSize); //координаты
        glVertex3d(worldSize, worldSize, -worldSize); // вершин
        glVertex3d(worldSize, 0, -worldSize);
    glEnd();

    glBegin(GL_QUADS);//стена
        glColor3f(0, 0, 0);
        glVertex3d(-worldSize, 0, -worldSize);
        glVertex3d(-worldSize, worldSize, -worldSize); //координаты
        glVertex3d(-worldSize, worldSize, worldSize); // вершин
        glVertex3d(-worldSize, 0, worldSize);
    glEnd();

    glBegin(GL_QUADS);//стена
    glColor3f(0, 0, 0);
    glVertex3d(worldSize, 0, worldSize);
    glVertex3d(worldSize, worldSize, worldSize); //координаты
    glVertex3d(-worldSize, worldSize, worldSize); // вершин
    glVertex3d(-worldSize, 0, worldSize);
    glEnd();

    glBegin(GL_QUADS);//стена
    glColor3f(0, 0, 0);
    glVertex3d(worldSize, 0, worldSize);
    glVertex3d(worldSize, worldSize, worldSize); //координаты
    glVertex3d(worldSize, worldSize, -worldSize); // вершин
    glVertex3d(worldSize, 0, -worldSize);
    glEnd();*/
/*
    glDisable(GL_TEXTURE_2D);

    glEndList();
}

void init() {
    glEnable(GL_DEPTH_TEST);
    glLightfv(GL_LIGHT0, GL_DIFFUSE, WHITE);
    glLightfv(GL_LIGHT0, GL_SPECULAR, WHITE);
    glMaterialfv(GL_FRONT, GL_SPECULAR, WHITE);
    glMaterialf(GL_FRONT, GL_SHININESS, 30);
    glEnable(GL_LIGHTING);
    glEnable(GL_LIGHT0);
    createWorld();
}

void display() {
    glClearColor(0.3, 0.75, 1., 1.);
    glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
    glLoadIdentity();

    gluLookAt(moveOldx, 1., moveOldz,
        rotateOldX, 1, rotateOldY,
        0.f, 1.f, 0.f);
    glCallList(displayListId);
    for (int i = 0; i < 3; i++) {
        teapots[i].update();
    }
    createRamp();
    glFlush();
    glutSwapBuffers();
}

void reshape(GLint w, GLint h) {
    glViewport(0, 0, w, h);
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
    gluPerspective(40.0, GLfloat(w) / GLfloat(h), 1.0, 150.0);
    glMatrixMode(GL_MODELVIEW);
}

void timer(int v) 
{
    glutPostRedisplay();
    glutTimerFunc(1000 / 60, timer, v);
}

GLuint LoadTexture(const char* filename)
{
    GLuint texture;
    int width, height;
    unsigned char* data;

    FILE* file;
    file = fopen(filename, "rb");
    if (file == NULL) return 0;
    printf("ttt");
    width = 1024;
    height = 512;
    data = (unsigned char*)malloc(width * height * 3);
    //int size = fseek(file,);
    fread(data, width * height * 3, 1, file);
    fclose(file);

    for (int i = 0; i < width * height; ++i)
    {
        int index = i * 3;
        unsigned char B, R;
        B = data[index];
        R = data[index + 2];

        data[index] = R;
        data[index + 2] = B;
    }

    glGenTextures(1, &texture);
    glBindTexture(GL_TEXTURE_2D, texture);
    glTexEnvf(GL_TEXTURE_ENV, GL_TEXTURE_ENV_MODE, GL_MODULATE);
    glTexParameterf(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR_MIPMAP_NEAREST);

    glTexParameterf(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR);
    glTexParameterf(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_REPEAT);
    glTexParameterf(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_REPEAT);
    gluBuild2DMipmaps(GL_TEXTURE_2D, 3, width, height, GL_RGB, GL_UNSIGNED_BYTE, data);
    free(data);

    return texture;
}

void specialKeys(int key, int x, int y)
{
    if (key == GLUT_KEY_RIGHT)
    {
        moveOldx += 1;
        //rotateOldX += 1;
    }
    else if (key == GLUT_KEY_LEFT)
    {
        moveOldx -= 1;
        //rotateOldX -= 1;
    }
    else if (key == GLUT_KEY_UP)
    {
        moveOldz += 1;
        //rotateOldY += 1;
    }
    else if (key == GLUT_KEY_DOWN)
    {
        moveOldz -= 1;
        //rotateOldY -= 1;
    }
    glutPostRedisplay();
}*/
