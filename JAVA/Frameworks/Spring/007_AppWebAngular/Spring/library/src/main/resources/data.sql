drop table if exists book CASCADE;

drop table if exists category CASCADE;

drop table if exists customer CASCADE;

drop table if exists loan CASCADE;

create table category (
    code varchar(255) not null,
    label varchar(255) not null,
    primary key (code)
);

create table book (
    book_id integer not null AUTO_INCREMENT,
    author varchar(255),
    isbn varchar(255) not null unique,
    register_date date not null,
    release_date date not null,
    title varchar(255) not null,
    total_examplaries integer,
    cat_code varchar(255) not null,
    primary key (book_id),
    foreign key (cat_code) references category
);

create table customer (
    customer_id integer not null AUTO_INCREMENT,
    address varchar(255),
    creation_date date not null,
    email varchar(255) not null unique,
    first_name varchar(255) not null,
    job varchar(255),
    last_name varchar(255) not null,
    primary key (customer_id)
);

create table loan (
    creation_date_time timestamp not null,
    begin_date date not null,
    end_date date not null,
    status varchar(255),
    customer_id integer  ,
    book_id integer ,
    primary key (book_id, creation_date_time, customer_id)
); 

ALTER TABLE loan 
    ADD FOREIGN KEY (customer_id)
    REFERENCES customer(customer_id);

ALTER TABLE loan
   ADD FOREIGN KEY (book_id)
   REFERENCES book (book_id);
   
INSERT INTO category (code, label) VALUES ('POL', 'POLAR');
INSERT INTO category (code, label) VALUES ('THR', 'THRILLER');
INSERT INTO category (code, label) VALUES ('FAN', 'FANTASY');

INSERT INTO book (author, isbn, register_date, release_date, title, total_examplaries, cat_code) VALUES ('Stephen KING', 'KIN-BRU', '1998-04-16', '2001-11-09', 'Brume', 4, 'THR');
INSERT INTO book (author, isbn, register_date, release_date, title, total_examplaries, cat_code) VALUES ('Stephen KING', 'KIN-LAT', '1988-04-16', '2001-11-09', 'La tour sombre', 12, 'THR');
INSERT INTO book (author, isbn, register_date, release_date, title, total_examplaries, cat_code) VALUES ('Stephen KING', 'KIN-CAI', '1995-04-06', '2001-11-09', 'Ca, il est revenu', 12, 'THR');
INSERT INTO book (author, isbn, register_date, release_date, title, total_examplaries, cat_code) VALUES ('J.R.R TOLKIEN', 'TOL-SD1', '1995-04-06', '2001-11-09', 'Le seigneur des annéeaux 1', 12, 'FAN');
INSERT INTO book (author, isbn, register_date, release_date, title, total_examplaries, cat_code) VALUES ('J.R.R TOLKIEN', 'TOL-SD2', '1995-04-06', '2001-11-09', 'Le seigneur des annéeaux 2', 12, 'FAN');
INSERT INTO book (author, isbn, register_date, release_date, title, total_examplaries, cat_code) VALUES ('J.R.R TOLKIEN', 'TOL-SD3', '1995-04-06', '2001-11-09', 'Le seigneur des annéeaux 3', 12, 'FAN');

COMMIT;