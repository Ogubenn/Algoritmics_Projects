<?php
$db = new PDO('mysql:host=localhost;dbname=ogubenn_meeting;charset=utf8', 'ogubenn_meeting', 'DtXccXxKTuRNVdxf6Wdt');

function query($query, $connection, $debug=0){
    if($debug==1) echo "<div>$query</div>";
    $result=$connection->query($query);
    (int)$count=$result->rowCount();
    if($count>0){
        $decod = $result->fetchAll(PDO::FETCH_ASSOC);
        return $decod;
    }else{
        return array();
    }
}

$act = $_GET["action"];
$post = $_REQUEST;

unset($post["action"]);

if ($act == "addMeeting")
{
   // Yeni randevu ekleme işlemi
   query("INSERT INTO meeting (phone, course, teacher,name_surname,meet_date,ammo_link,meet_case,data) VALUES ('".$post["phone"]."','".$post["course"]."','".$post["teacher"]."','".$post["name_surname"]."','".$post["meet_date"]."','".$post["ammo_link"]."','".$post["meet_case"]."','".$post["data"]."')", $db);
}
if ($act == "editMeeting")
{
    if(isset($post["meet_case"])) {
        query("UPDATE meeting SET meet_case = '".$post["meet_case"]."' WHERE id = '".$post["id"]."'", $db);
        echo "success";
    } else {
        echo "error";
    }
}

if ($act == "deleteMeeting")
{
    // Silme işlemi
}
if ($act == "getMeeting")
{
    echo json_encode(query("SELECT * FROM meeting", $db), JSON_UNESCAPED_UNICODE);
}

if ($act == "viewMeeting")
{
    $array = query("SELECT * FROM meeting", $db);
 ?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ÇM3-Osman</title>
    <link rel="stylesheet" href="https://cdn.datatables.net/1.10.24/css/jquery.dataTables.min.css">
    <style>
        /* Özel CSS Stilleri */
        /* DataTables Özel Stillendirme */
        #example_wrapper {
    margin: 50px;
    padding: 20px;
    border: 1px solid #ddd;
    border-radius: 8px;
    background-color: #f9f9f9;
    box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1); /* Hafif bir gölgelendirme ekleyin */
}


.dataTables_length,
.dataTables_filter,
.dataTables_info,
.dataTables_paginate {
    margin-top: 10px;
    white-space: nowrap; /* Metnin alt alta geçmesini engelle */
}

.dataTables_length label,
.dataTables_filter label {
    margin-right: 10px;
    white-space: nowrap; /* Metnin alt alta geçmesini engelle */
}

.dataTables_paginate {
    margin-top: 20px;
    white-space: nowrap; /* Metnin alt alta geçmesini engelle */
}


.dataTables_paginate .paginate_button {
    padding: 5px 10px;
    margin-right: 5px;
    border: 1px solid #aaa;
    border-radius: 5px;
    background-color: #f0f0f0;
    color: #333;
}

.dataTables_paginate .paginate_button:hover {
    background-color: #ddd;
}
        .meet_case_select {
    border: none;
    border-radius: 20px; /* Yuvarlak köşeler */
    padding: 8px 15px; /* Kenar boşlukları */
    background-color: #f0f0f0; /* Arka plan rengi */
    font-size: 14px;
    color: #333; /* Metin rengi */
    cursor: pointer;
    outline: none;
    transition: background-color 0.3s ease;
}

.meet_case_select:hover {
    background-color: #e0e0e0; /* Hover rengi */
}

.meet_case_select:focus {
    background-color: #d0d0d0; /* Seçildiğindeki rengi */
}

/* Seçeneklerin stili */
.meet_case_select option {
    background-color: transparent; /* Seçeneklerin arka plan rengi */
    border-radius: 0; /* Seçeneklerin köşe yuvarlaklığı */
}

    </style>
</head>
<body>
    <table id="example" class="display" style="width:70%">
        <thead>
            <tr>
                <th>ID</th>
                <th>Oluşturma Tarihi</th>
                <th>Telefon</th>
                <th>Kurs</th>
                <th>Eğitmen</th>
                <th>İsim Soyisim</th>
                <th>Randevu Tarihi</th>
                <th>Ammo Link</th>
                <th>Randevu Durumu</th>
                <th>Data</th>
            </tr>
        </thead>
        <tbody>
            <?php foreach($array as $item) { ?>
            <tr>
                <td><?= $item["id"] ?></td>
                <td><?= $item["create_date"] ?></td>
                <td><?= $item["phone"] ?></td>
                <td><?= $item["course"] ?></td>
                <td><?= $item["teacher"] ?></td>
                <td><?= $item["name_surname"] ?></td>
                <td><?= $item["meet_date"] ?></td>
                <td><a href="<?= $item["ammo_link"] ?>" target="_blank"><?= $item["ammo_link"] ?></a></td>
                <td class="meet_case" data-id="<?= $item["id"] ?>" data-case="<?= $item["meet_case"] ?>">
                    <select class="meet_case_select">
                        <option value="Randevu Alındı" <?= ($item["meet_case"] == "Randevu Alındı") ? "selected" : "" ?>>Randevu Alındı</option>
                        <option value="Randevu Teyit Edildi" <?= ($item["meet_case"] == "Randevu Teyit Edildi") ? "selected" : "" ?>>Randevu Teyit Edildi</option>
                        <option value="Randevu Gerçekleşti" <?= ($item["meet_case"] == "Randevu Gerçekleşti") ? "selected" : "" ?>>Randevu Gerçekleşti</option>
                        <option value="Randevu İptal Edildi" <?= ($item["meet_case"] == "Randevu İptal Edildi") ? "selected" : "" ?>>Randevu İptal Edildi</option>
                        
                    </select>
                </td>
                <td><?= $item["data"] ?></td>
            </tr>
            <?php } ?>
        </tbody>
    </table>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdn.datatables.net/1.10.24/js/jquery.dataTables.min.js"></script>
    <script>
    $(document).ready(function() {
        // DataTables başlatma
        var table = $('#example').DataTable({
            "order": [[ 0, "asc" ]] // İlk sıraya göre sıralama
        });

        // Randevu Durumu sütununu açılır menü haline getirme
        $('#example').on('change', '.meet_case_select', function() {
            var id = $(this).closest('td').data('id');
            var meet_case = $(this).val();
            $.ajax({
                url: 'https://ogubenn.com.tr/meeting.php?action=editMeeting', // Güncelleme işlemini yapan PHP dosyası
                type: 'POST',
                data: { id: id, meet_case: meet_case },
                success: function(response) {
                    // Başarılı güncelleme durumunda
                    console.log(response);
                    // Sayfayı yeniden yükle
                    location.reload();
                },
                error: function(xhr, status, error) {
                    // Hata durumunda
                    console.error(xhr.responseText);
                }
            });
        });
        

        // Satır renklerini güncelleme fonksiyonu
        function updateRowColors() {
            $('#example tbody tr').each(function() {
                var meetCase = $(this).find('.meet_case_select').val();
                switch(meetCase) {
                    case 'Randevu Alındı':
                        $(this).css('background-color', '#f4ed69'); // Hafif sarı tonu
                        break;
                        case 'Randevu Teyit Edildi':
                        $(this).css('background-color', '#776ec9'); // Hafif mavi tonu
                        break;
                    case 'Randevu Gerçekleşti':
                        $(this).css('background-color', '#7eff6d'); // Hafif yeşil tonu
                        break;
                    case 'Randevu İptal Edildi':
                        $(this).css('background-color', '#ff6d6d'); // Hafif kırmızı tonu
                        break;
                    default:
                        $(this).css('background-color', 'transparent');
                }
            });
        }

        // Sayfa yüklendiğinde satır renklerini güncelle
        updateRowColors();

        // DataTables'in draw olayında satır renklerini güncelle
        $('#example').on('draw.dt', function() {
            updateRowColors();
        });
    });
</script>

</body>
</html>
 <?php } ?>
