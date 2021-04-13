FROM nginx:alpine

WORKDIR /Build
COPY Build/ .

WORKDIR /etc/nginx/conf.d
RUN rm default.conf
COPY webgl.conf webgl.conf
