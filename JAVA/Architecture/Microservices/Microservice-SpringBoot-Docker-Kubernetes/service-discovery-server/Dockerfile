# syntax=docker/dockerfile:1

FROM openjdk:17-alpine
EXPOSE 8761
ARG JAR_FILE=build/libs/*.jar
COPY ${JAR_FILE} app.jar
CMD ["java", "-jar","app.jar"]