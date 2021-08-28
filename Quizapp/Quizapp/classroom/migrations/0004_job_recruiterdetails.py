# Generated by Django 2.0.1 on 2018-10-26 06:01

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('classroom', '0003_quiz_password'),
    ]

    operations = [
        migrations.CreateModel(
            name='Job',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('offer', models.CharField(max_length=255)),
                ('primary_profile', models.CharField(max_length=255)),
                ('location', models.CharField(max_length=255)),
                ('no_of_position', models.IntegerField()),
                ('apply_deadline', models.CharField(max_length=10)),
                ('drive_date', models.CharField(max_length=10)),
                ('organization_sector', models.CharField(max_length=255)),
                ('job_decription', models.CharField(max_length=255)),
                ('package', models.IntegerField()),
                ('required_skills', models.CharField(max_length=255)),
                ('min_CPI', models.DecimalField(decimal_places=2, max_digits=4)),
                ('selection_process', models.CharField(max_length=255)),
                ('other_details', models.CharField(max_length=255)),
            ],
        ),
        migrations.CreateModel(
            name='RecruiterDetails',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('first_name', models.CharField(max_length=255)),
                ('last_name', models.CharField(max_length=255)),
                ('email', models.EmailField(blank=True, max_length=70, null=True, unique=True)),
                ('mobile', models.CharField(max_length=10)),
                ('organization_name', models.CharField(blank=True, max_length=255, unique=True)),
                ('organization_email', models.EmailField(blank=True, max_length=70, null=True, unique=True)),
                ('organization_description', models.CharField(max_length=255)),
                ('organization_logo', models.ImageField(blank=True, upload_to='organization_logo')),
            ],
        ),
    ]
